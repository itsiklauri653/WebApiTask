using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Domain.AggregatesModel.BaseAggregate
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public Status Status { get; set; }
    }
}
