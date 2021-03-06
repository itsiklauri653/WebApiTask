using System.Threading.Tasks;

namespace PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> Get(int? id);
        void Create(Customer obj);
        void Update(Customer obj);
        Task Delete(int? id);
    }
}
