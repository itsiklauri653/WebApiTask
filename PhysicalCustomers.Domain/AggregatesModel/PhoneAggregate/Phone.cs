using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using System.ComponentModel.DataAnnotations;

namespace PhysicalCustomers.Domain.AggregatesModel.PhoneAggregate
{
    public class Phone : BaseEntity
    {
        [Required]
        public PhoneType Type { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string Number { get; set; }
    }
}
