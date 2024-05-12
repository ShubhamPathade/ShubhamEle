using Project.Core.Domain.Users;
using System.Collections.Generic;

namespace Project.Core
{
    /// <summary>
    /// Represents work context.
    /// </summary>
    public interface IWorkContext
    {
        #region Properties

        /// <summary>
        /// Gets or sets the current customer.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Get user roles.
        /// </summary>
        public IEnumerable<string> Roles { get; }

        #endregion
    }
}
