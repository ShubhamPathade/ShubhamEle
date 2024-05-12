using System;

namespace Project.Core
{
    public abstract class BaseEntity : BaseModel
    {
        #region Properties

        public long Id { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        #endregion
    }
}
