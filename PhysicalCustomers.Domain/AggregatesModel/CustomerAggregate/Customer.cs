using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using PhysicalCustomers.Domain.AggregatesModel.ConnectedCustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.PhoneAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate
{
    public class Customer : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        [Required]
        public string PersonalId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public City City { get; set; }
        [Required]
        public int CityId { get; set; }
        public IList<Phone> Phones { get; set; }
        public string GraphicalData { get; set; }
        public IList<ConnectedCustomer> ConnectedCustomers { get; set; }
    }
}
