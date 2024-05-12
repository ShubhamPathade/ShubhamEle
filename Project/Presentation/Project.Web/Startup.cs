using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Project.Data;
using Project.Web.Infrastructure.Extensions;
using System.IO;

namespace Project.Web
{
    public class Startup
    {
        #region Fields

        private readonly IConfiguration _configuration;

        #endregion

        #region Constructor

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add services to the application and configure service provider
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IFileProvider>(
            //new PhysicalFileProvider(
            //    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));

            #region Enabled this when using migration 

            services.AddDbContext<ProjectDataContext>(otp => otp.UseSqlServer("Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=shubhamelectricals_dev;Integrated Security=False;Persist Security Info=False;User ID=shubhamelectricals_dev;Password=sp1234;"));

            #endregion

            services.ConfigureApplicationServices(_configuration);
        }

        /// <summary>
        /// Configure the application HTTP request pipeline
        /// </summary>
        public void Configure(IApplicationBuilder app)
        {
            app.ConfigureRequestPipeline();
        }

        #endregion
    }
}
