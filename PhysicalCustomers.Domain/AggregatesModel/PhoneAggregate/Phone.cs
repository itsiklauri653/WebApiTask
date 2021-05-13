

using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;

namespace PhysicalCustomers.Domain.AggregatesModel.PhoneAggregate
{
    public class Phone : BaseEntity
    {
        public PhoneType Type { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public string Number { get; set; }
    }
}
