using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using System.ComponentModel.DataAnnotations;

namespace PhysicalCustomers.Domain.AggregatesModel.ConnectedCustomerAggregate
{
    public class ConnectedCustomer : BaseEntity
    {
        [Required]
        public CustomerConnectionType ConnectionType { get; set; }
        public Customer CustomerFrom { get; set; }
        [Required]
        public int CustomerFromId { get; set; }
        public Customer CustomerTo { get; set; }
        [Required]
        public int CustomerToId { get; set; }
    }
}
