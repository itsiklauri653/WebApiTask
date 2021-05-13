using PhysicalCustomers.Application.Customers;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalCustomers.Application.Core.Extensions
{
    public class PagingHelpers
    {
        public static IQueryable<CustomerViewModel> Search(IQueryable<CustomerViewModel> customers,string keyword)
        {
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                customers = customers.Where(c =>
                    c.FirstName.Contains(keyword)
                    || c.LastName.Contains(keyword)
                    || c.PersonalId.Contains(keyword));
            }
            return customers;
        }

        public static IQueryable<CustomerViewModel> Search(IQueryable<CustomerViewModel> customers, string firstName, string lastName, string personalId)
        {
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                customers = customers.Where(c =>
                    c.FirstName.Contains(firstName));
            }

            if (!string.IsNullOrWhiteSpace(lastName))
            {
                customers = customers.Where(c =>
                    c.LastName.Contains(lastName));
            }

            if (!string.IsNullOrWhiteSpace(personalId))
            {
                customers = customers.Where(c =>
                    c.PersonalId.Contains(personalId));
            }
            return customers;
        }

        public static IQueryable<CustomerViewModel> Sort(IQueryable<CustomerViewModel> customers, string sort, string order)
        {
            switch (sort)
            {
                case "FirstName":
                    customers = order.Equals("desc") ? customers.OrderByDescending(c => c.FirstName)
                        : customers.OrderBy(c => c.FirstName);
                    break;
                case "LastName":
                    customers = order.Equals("desc") ? customers.OrderByDescending(c => c.LastName)
                        : customers.OrderBy(c => c.LastName);
                    break;
                default:
                    customers = customers.OrderBy(c => c.Id);
                    break;
            }

            return customers;
        }
    }
}
