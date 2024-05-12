using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Core.Infrastructure;
using Project.Web.Infrastructure.Extensions;

namespace Project.Web.Infrastructure
{
    public class ProjectMvcStartup : IProjectStartup
    {
        #region Methods

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddRazorPages().AddRazorRuntimeCompilation();

            //add and configure MVC feature
            services.AddProjectMvc();
        }

        public void Configure(IApplicationBuilder application)
        {
            //Endpoints routing
            application.UseNopEndpoints();
        }

        #endregion

        #region Properties

        public int Order => 1000;

        #endregion
    }
}
