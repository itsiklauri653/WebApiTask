using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Application.Core.Interfaces
{
    public interface ICityService : IBaseService<City>
    {
        Task Create(City obj);
        void Update(City obj);
    }
}
