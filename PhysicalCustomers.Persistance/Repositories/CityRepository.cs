using Microsoft.EntityFrameworkCore;
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
        public async Task<IQueryable<City>> GetAll()
        {
            return _context.Cities.AsNoTracking();
        }
    }
}
