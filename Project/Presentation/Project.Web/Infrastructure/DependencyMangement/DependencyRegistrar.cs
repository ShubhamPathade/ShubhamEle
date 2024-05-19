using Microsoft.Extensions.DependencyInjection;
using Project.Core.Configuration;
using Project.Core.Infrastructure;
using Project.Core.Infrastructure.DependencyMangement;
using Project.Web.Infrastructure.Factory.Electricians;
using Project.Web.Infrastructure.Services;

namespace Project.Web.Infrastructure.DependencyMangement
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        #region Methods

        public void Register(IServiceCollection services, ITypeFinder typeFinder, AppSettings appSettings)
        {
            services.AddScoped<IFileUploadService, FileUploadService>();

            #region Factories
            services.AddScoped<IElectricianModelFactory, ElectricianModelFactory>();
            #endregion
        }

        #endregion

        #region Properties

        public int Order => 0;

        #endregion
    }
}
