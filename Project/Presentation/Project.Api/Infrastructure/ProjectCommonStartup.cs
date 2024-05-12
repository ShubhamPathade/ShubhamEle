using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Core.Infrastructure;
using Project.Services.Http;
using System;

namespace Project.Api.Infrastructure
{
    /// <summary>
    /// Represents object for the configuring common features and middleware on application startup
    /// </summary>
    public class ProjectCommonStartup : IProjectStartup
    {
        #region Methods

        /// <summary>
        /// Add and configure any of the middleware
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            //add http client
            services.AddHttpClient<IHttpService, HttpService>();

            //add and configure signalr feature
            services.AddSignalR(e => {
                e.MaximumReceiveMessageSize = 102400000;
            });

            //add distributed cache service
            services.AddDistributedSqlServerCache(options =>
            {
                options.ConnectionString = configuration.GetValue<string>("ConnectionString");
                options.TableName = "TruckBhejoCache";
                options.SchemaName = "dbo";
                options.DefaultSlidingExpiration = new TimeSpan(12, 0, 0);
            });
        }

        /// <summary>
        /// Configure the using of added middleware
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        public void Configure(IApplicationBuilder application)
        {
            //use static files feature
            application.UseStaticFiles();

            application.UseHttpsRedirection();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets order of this startup configuration implementation
        /// </summary>
        public int Order => 100; //common services should be loaded after error handlers

        #endregion
    }
}
