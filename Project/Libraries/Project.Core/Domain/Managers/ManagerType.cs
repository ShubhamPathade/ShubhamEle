using System.Collections.Generic;

namespace Project.Core.Domain.Managers
{
    public class ManagerType : BaseEntity
    {
        #region Properties

        public string TypeName { get; set; }
        public string Description { get; set; }

        #endregion
    }
}
