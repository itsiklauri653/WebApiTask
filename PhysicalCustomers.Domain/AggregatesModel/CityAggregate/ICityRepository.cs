using System.Threading.Tasks;

namespace PhysicalCustomers.Domain.AggregatesModel.CityAggregate
{
    public interface ICityRepository : IRepository<City>
    {
        Task<City> Get(int? id);
        void Create(City obj);
        void Update(City obj);
        Task Delete(int? id);
    }
}
