using Microsoft.AspNetCore.Http;
using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using PhysicalCustomers.Domain.AggregatesModel.ConnectedCustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.PhoneAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhysicalCustomers.Application.Customers
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string PersonalId { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public IList<Phone> Phones { get; set; }
        public string GraphicalData { get; set; }
        public Status Status { get; set; }
        public IFormFile Image { get; set; }
        public IList<ConnectedCustomer> ConnectedCustomers { get; set; }
    }
}
