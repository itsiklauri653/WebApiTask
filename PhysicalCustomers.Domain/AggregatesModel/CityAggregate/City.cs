using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Domain.AggregatesModel.CityAggregate
{
    public class City : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
