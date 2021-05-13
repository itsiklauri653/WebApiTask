using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Application.Core.Interfaces
{
    public interface IBaseService<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(int? id);
        Task Delete(int? id);
    }
}
