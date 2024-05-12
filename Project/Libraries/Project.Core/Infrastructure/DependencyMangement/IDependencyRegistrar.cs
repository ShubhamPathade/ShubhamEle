using Project.Core.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Project.Core.Infrastructure.DependencyMangement
{
    /// <summary>
    /// Dependency registrar interface
    /// </summary>
    public interface IDependencyRegistrar
    {
        #region Methods

        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="appSettings">App settings</param>
        void Register(IServiceCollection services, ITypeFinder typeFinder, AppSettings appSettings);

        /// <summary>
        /// Gets order of this dependency registrar implementation
        /// </summary>
        int Order { get; }

        #endregion
    }
}
