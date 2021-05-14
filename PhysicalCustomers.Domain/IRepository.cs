using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalCustomers.Domain
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
    }
}
