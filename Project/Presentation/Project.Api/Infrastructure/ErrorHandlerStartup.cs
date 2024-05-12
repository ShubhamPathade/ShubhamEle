using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.Core.Infrastructure;

namespace Project.Api.Infrastructure
{
    /// <summary>
    /// Represents object for the configuring exceptions and errors handling on application startup
    /// </summary>
    public class ErrorHandlerStartup : IProjectStartup
    {
        #region Methods

        /// <summary>
        /// Add and configure any of the middleware
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
        }

        /// <summary>
        /// Configure the using of added middleware
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        public void Configure(IApplicationBuilder application)
        {
            var environment = EngineContext.Current.Resolve<IHostEnvironment>();

            if (environment.IsDevelopment())
            {
                //exception handling
                application.UseDeveloperExceptionPage();
            }

        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets order of this startup configuration implementation
        /// </summary>
        public int Order => 0; //error handlers should be loaded first

        #endregion
    }
}
