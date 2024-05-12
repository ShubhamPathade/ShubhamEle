namespace Project.Core.Domain.Customers
{
    public class CustomerWallet : BaseEntity
    {
        public long CustomerId { get; set; }
        public decimal Amount { get; set; }

        public Customer Customer { get; set; }
    }
}
