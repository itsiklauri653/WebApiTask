using System.ComponentModel.DataAnnotations;

namespace PhysicalCustomers.Domain.AggregatesModel.BaseAggregate
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public Status Status { get; set; }
    }
}
