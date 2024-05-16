using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Core;
using Project.Core.Configuration;
using Project.Core.Data;
using Project.Core.Infrastructure;
using Project.Core.Infrastructure.DependencyMangement;
using Project.Data;
using Project.Services.Cities;
using Project.Services.Electricians;
using Project.Services.Notifications;
using Project.Services.Roles;
using Project.Services.States;
using Project.Services.Users;
using Project.Web.Framework.Routing;
namespace Project.Web.Framework.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        #region Methods

        public void Register(IServiceCollection services, ITypeFinder typeFinder, AppSettings appSettings)
        {
            //data
            services.AddDbContext<IDbContext, ProjectDataContext>(options =>
            {
                options.UseSqlServer(appSettings.ConnectionString);
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //context
            services.AddScoped<IWorkContext, WorkContext>();

            //routing
            services.AddSingleton<IRoutePublisher, RoutePublisher>();

            //repositories
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddScoped(typeof(IModelService<>), typeof(ModelService<>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddScoped(typeof(IModelService<>), typeof(ModelService<>));
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<INotificationService, EmailNotificationSerice>();

            // New
            services.AddScoped<IStateService, StateService>();  
            services.AddScoped<ICityService, CityService>();  
            services.AddScoped<IElectricianService, ElectricianService>();  

        }

        #endregion

        #region Properties

        public int Order => 0;

        #endregion
    }
}
