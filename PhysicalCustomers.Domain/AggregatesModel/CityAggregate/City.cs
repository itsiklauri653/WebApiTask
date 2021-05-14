using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using System.ComponentModel.DataAnnotations;

namespace PhysicalCustomers.Domain.AggregatesModel.CityAggregate
{
    public class City : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
