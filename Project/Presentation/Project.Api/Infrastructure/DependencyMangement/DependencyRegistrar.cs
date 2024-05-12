using Microsoft.Extensions.DependencyInjection;
using Project.Api.Infrastructure.Services;
using Project.Core.Configuration;
using Project.Core.Infrastructure;
using Project.Core.Infrastructure.DependencyMangement;
//using Project.Services.Customers;
using Project.Services.Http;
//using Project.Services.Managers;
//using Project.Services.Vendors;
//using Project.Services.WhatsAppChatBotServices;

namespace Project.Api.Infrastructure.DependencyMangement
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        #region Methods

        public void Register(IServiceCollection services, ITypeFinder typeFinder, AppSettings appSettings)
        {
            services.AddHttpClient<IHttpService, HttpService>();
            services.AddScoped<IFileUploadService, FileUploadService>();
            services.AddScoped<IJwtAuthManager, JwtAuthManager>();
        }

        #endregion

        #region Properties

        public int Order => 0;

        #endregion
    }
}
