﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Api.Infrastructure.Middlewares;
using Project.Core.Infrastructure;

namespace Project.Api.Infrastructure
{
    /// <summary>
    /// Represents object for the configuring Authorization middleware on application startup
    /// </summary>
    public class AuthorizationStartup : IProjectStartup
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
            //Add the Authorization middleware
            application.UseAuthorization();

            //truckbhejo user token validator
            application.UseMiddleware<TruckBhejoUserTokenValidator>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets order of this startup configuration implementation
        /// </summary>
        public int Order => 600;

        #endregion
    }
}
