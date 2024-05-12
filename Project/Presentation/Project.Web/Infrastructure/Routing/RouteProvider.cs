using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Project.Web.Framework.Routing;

namespace Project.Web.Infrastructure.Routing
{
    public class RouteProvider : IRouteProvider
    {
        #region Methods

        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            //areas
            endpointRouteBuilder.MapControllerRoute(name: "Admin", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            endpointRouteBuilder.MapControllerRoute("Default", "{controller=User}/{action=Login}/{id?}");
        }

        #endregion

        #region Properties

        public int Priority => 0;

        #endregion
    }
}
