using Microsoft.AspNetCore.Builder;
using Project.Core.Infrastructure;

namespace Project.Api.Infrastructure.Extensions
{
    /// <summary>
    /// Represents extensions of IApplicationBuilder
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        #region Methods

        /// <summary>
        /// Configure the application HTTP request pipeline
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        public static void ConfigureRequestPipeline(this IApplicationBuilder application)
        {
            EngineContext.Current.ConfigureRequestPipeline(application);
        }

        /// <summary>
        /// Configure Endpoints routing
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        public static void UseProjetEndpoints(this IApplicationBuilder application)
        {
            //Execute the endpoint selected by the routing middleware
            application.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        #endregion
    }
}
