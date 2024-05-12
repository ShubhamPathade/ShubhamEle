using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Project.Api.Hubs;
using Project.Api.Infrastructure.Extensions;
using Project.Core.Infrastructure;

namespace Project.Api.Infrastructure
{
    public class ProjectApiStartup : IProjectStartup
    {
        #region Methods

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            //add and configure api feature
            //services.AddControllers();
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder application)
        {
            application.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //endpoints.MapHub<PtlHub>("/PtlHub");
            });
        }

        #endregion

        #region Properties

        public int Order => 1000;

        #endregion
    }
}
