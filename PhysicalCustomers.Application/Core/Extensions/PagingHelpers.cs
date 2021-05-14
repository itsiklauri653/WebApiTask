using PhysicalCustomers.Application.Customers;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhysicalCustomers.Application.Core.Extensions
{
    public class PagingHelpers
    {
        public static List<CustomerViewModel> Search(List<CustomerViewModel> customers, string keyword)
        {
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                customers = customers.Where(c =>
                    c.FirstName.Contains(keyword)
                    || c.LastName.Contains(keyword)
                    || c.PersonalId.Contains(keyword)).ToList();
            }
            return customers;
        }

        public static List<CustomerViewModel> Search(List<CustomerViewModel> customers, string firstName,
            string lastName, string personalId, string birthDate, string gender, string city, string phone, string connectedCustomer)
        {
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                customers = customers.Where(c =>
                    c.FirstName.Contains(firstName)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(lastName))
            {
                customers = customers.Where(c =>
                    c.LastName.Contains(lastName)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(personalId))
            {
                customers = customers.Where(c =>
                    c.PersonalId.Contains(personalId)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(birthDate))
            {
                var date = DateTime.Parse(birthDate);

                customers = customers.Where(c =>
                    c.BirthDate == date).ToList();
            }

            if (!string.IsNullOrWhiteSpace(gender))
            {
                var genderType = GenderType.Male;
                if (gender.Equals("male", StringComparison.CurrentCultureIgnoreCase))
                    genderType = GenderType.Male;
                else
                    genderType = GenderType.Female;

                customers = customers.Where(c => c.Gender == genderType).ToList();
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                customers = customers.Where(c =>
                    c.City.Name.Contains(city, StringComparison.CurrentCultureIgnoreCase)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(phone))
            {
                customers = customers.Where(c =>
                    c.Phones.Any(p => p.Number == phone)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(connectedCustomer))
            {
                customers = customers.Where(c =>
                    c.ConnectedCustomers.Any(cc => cc.CustomerTo.FirstName.Contains(connectedCustomer)
                    || cc.CustomerTo.LastName.Contains(connectedCustomer) ||
                    (cc.CustomerTo.FirstName + cc.CustomerTo.LastName).Contains(connectedCustomer))).ToList();
            }
            return customers;
        }

        public static List<CustomerViewModel> Sort(List<CustomerViewModel> customers, string sort, string order)
        {
            switch (sort)
            {
                case "FirstName":
                    customers = order.Equals("desc") ? customers.OrderByDescending(c => c.FirstName).ToList()
                        : customers.OrderBy(c => c.FirstName).ToList();
                    break;
                case "LastName":
                    customers = order.Equals("desc") ? customers.OrderByDescending(c => c.LastName).ToList()
                        : customers.OrderBy(c => c.LastName).ToList();
                    break;
                default:
                    customers = customers.OrderBy(c => c.Id).ToList();
                    break;
            }

            return customers;
        }
    }
}
