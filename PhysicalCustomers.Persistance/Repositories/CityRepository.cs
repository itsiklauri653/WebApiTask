using Microsoft.EntityFrameworkCore;
using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalCustomers.Persistance.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _context;

        public CityRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(City obj)
        {
            _context.Cities.Add(obj);
            obj.Status = Status.IsActive;
        }

        public async Task Delete(int? id)
        {
            var city = await Get(id);
            city.Status = Status.IsDeleted;
        }

        public async Task<City> Get(int? id)
        {
            return await _context.Cities.FirstOrDefaultAsync(c => c.Id == id && c.Status == Status.IsActive);
        }

        public async Task<List<City>> GetAll()
        {
            return await _context.Cities.Where(c => c.Status == Status.IsActive).ToListAsync();
        }

        public void Update(City obj)
        {
            _context.Cities.Update(obj);
        }
    }
}
