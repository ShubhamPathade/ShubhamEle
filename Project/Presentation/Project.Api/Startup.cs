using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.Api.Infrastructure.Extensions;

namespace Project.Api
{
    public class Startup
    {
        #region Fields

        public IConfiguration _configuration { get; }


        #endregion

        #region Constructor


        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #endregion

        #region Methods

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureApplicationServices(_configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.ConfigureRequestPipeline();
        }


        #endregion
    }
}
