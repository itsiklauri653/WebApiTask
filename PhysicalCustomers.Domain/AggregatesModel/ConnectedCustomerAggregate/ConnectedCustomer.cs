using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;

namespace PhysicalCustomers.Domain.AggregatesModel.ConnectedCustomerAggregate
{
    public class ConnectedCustomer : BaseEntity
    {
        public CustomerConnectionType ConnectionType { get; set; }
        public Customer CustomerFrom { get; set; }
        public int CustomerFromId { get; set; }
        public Customer CustomerTo { get; set; }
        public int CustomerToId { get; set; }
    }
}
