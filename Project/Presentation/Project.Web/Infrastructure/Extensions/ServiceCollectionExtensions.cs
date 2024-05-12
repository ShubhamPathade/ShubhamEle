using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Core.Configuration;
using Project.Core.Infrastructure;
using System.Net;

namespace Project.Web.Infrastructure.Extensions
{
    /// <summary>
    /// Represents extensions of IServiceCollection
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        #region Methods

        /// <summary>
        /// Add services to the application and configure service provider
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        /// <param name="webHostEnvironment">Hosting environment</param>
        /// <returns>Configured engine and app settings</returns>
        public static (IEngine, AppSettings) ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            //let the operating system decide what TLS protocol version to use
            //see https://docs.microsoft.com/dotnet/framework/network-programming/tls
            ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;

            //add accessor to HttpContext
            services.AddHttpContextAccessor();

            //add configuration parameters
            var appSettings = new AppSettings();
            configuration.Bind(appSettings);
            services.AddSingleton(appSettings);

            //create engine and configure service provider
            var engine = EngineContext.Create();

            engine.ConfigureServices(services, configuration);
            engine.RegisterDependencies(services, appSettings);

            return (engine, appSettings);
        }

        /// <summary>
        /// Register HttpContextAccessor
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddHttpContextAccessor(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        /// <summary>
        /// Add and configure MVC for the application
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <returns>A builder for configuring MVC services</returns>
        public static IMvcBuilder AddProjectMvc(this IServiceCollection services)
        {
            //add basic MVC feature
            var mvcBuilder = services.AddControllersWithViews();

            services.AddRazorPages().AddRazorRuntimeCompilation();

            //register controllers as services, it'll allow to override them
            mvcBuilder.AddControllersAsServices();

            return mvcBuilder;
        }

        /// <summary>
        /// Adds authentication service
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddProjectAuthentication(this IServiceCollection services)
        {
            //set default authentication schemes
            var authenticationBuilder = services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });

            //add main cookie authentication
            authenticationBuilder.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
            {
                options.Cookie.Name = $"Test";
                options.Cookie.HttpOnly = true;
                options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                options.LoginPath = "/User/Login";
            });
        }

        #endregion
    }
}
