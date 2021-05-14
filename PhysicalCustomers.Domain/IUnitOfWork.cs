using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using PhysicalCustomers.Domain.AggregatesModel.ConnectedCustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.PhoneAggregate;
using System.Threading.Tasks;

namespace PhysicalCustomers.Domain
{
    public interface IUnitOfWork
    {
        ICityRepository CityRepository { get; }
        IPhoneRepository PhoneRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IConnectedCustomerRepository ConnectedCustomerRepository { get; }
        Task SaveChangesAsync();
    }
}
