using PhysicalCustomers.Application.Customers;
using PhysicalCustomers.Domain.AggregatesModel.ConnectedCustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Application.Core.Interfaces
{
    public interface ICustomerService : IBaseService<CustomerViewModel>
    {
        Task DeleteConnectedCustomer(int? customerFromId, int? customerToId);
        Task<ConnectedCustomer> GetConnectedCustomer(int? fromId, int? toId);
        Task AddConnectedCustomer(ConnectedCustomer connectedCustomer);
        Task Create(CustomerViewModel obj, string webRoot);
        void Update(CustomerViewModel obj, string webRoot);
    }
}
