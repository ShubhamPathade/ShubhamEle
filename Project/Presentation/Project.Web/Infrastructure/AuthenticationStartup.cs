using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Core.Infrastructure;
using Project.Web.Infrastructure.Extensions;

namespace Project.Web.Infrastructure
{
    /// <summary>
    /// Represents object for the configuring authentication middleware on application startup
    /// </summary>
    public class AuthenticationStartup : IProjectStartup
    {
        #region Methods

        /// <summary>
        /// Add and configure any of the middleware
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            //add authentication
            services.AddProjectAuthentication();
        }

        /// <summary>
        /// Configure authentication middleware.
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        public void Configure(IApplicationBuilder application)
        {
            //configure authentication
            //application.UseAuthentication(); => pending
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets order of this startup configuration implementation
        /// </summary>
        public int Order => 500; //authentication should be loaded before MVC

        #endregion
    }
}
