using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Domain
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
    }
}
