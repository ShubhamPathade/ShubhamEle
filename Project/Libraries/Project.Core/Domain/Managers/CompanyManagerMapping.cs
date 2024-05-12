using Project.Core.Domain.Companies;

namespace Project.Core.Domain.Managers
{
    public class CompanyManagerMapping : BaseEntity
    {
        #region Properties

        public long ManagerId { get; set; }
        public long CompanyId { get; set; }

        public Company Company { get; set; }
        public Manager Manager { get; set; }


        #endregion
    }
}
