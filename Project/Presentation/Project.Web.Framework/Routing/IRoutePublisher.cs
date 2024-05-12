using Microsoft.AspNetCore.Routing;

namespace Project.Web.Framework.Routing
{
    /// <summary>
    /// Represents route publisher
    /// </summary>
    public interface IRoutePublisher
    {
        #region Methods

        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder);

        #endregion
    }
}
