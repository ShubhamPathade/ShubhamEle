using Project.Core.Domain.Companies;
using Project.Core.Domain.Users;

namespace Project.Core.Domain.Customers
{
    public class CustomerCompanyMapping : BaseEntity
    {
        #region Properties
        public long CompanyId { get; set; }
        public long CustomerId { get; set; }
        public  Company Company { get; set; }
        public  Customer Customer { get; set; }

        #endregion
    }
}
