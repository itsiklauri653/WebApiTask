using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using System.Threading.Tasks;

namespace PhysicalCustomers.Application.Core.Interfaces
{
    public interface ICityService : IBaseService<City>
    {
        Task Create(City obj);
        void Update(City obj);
    }
}
