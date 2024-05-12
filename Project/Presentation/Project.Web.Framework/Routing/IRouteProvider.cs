using Microsoft.AspNetCore.Routing;

namespace Project.Web.Framework.Routing
{
    /// <summary>
    /// Route provider
    /// </summary>
    public interface IRouteProvider
    {
        #region Methods

        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder);

        #endregion

        #region Properties

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        int Priority { get; }

        #endregion
    }
}
