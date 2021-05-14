using Microsoft.EntityFrameworkCore;
using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalCustomers.Persistance.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(Customer obj)
        {
            _context.Customers.Add(obj);
            obj.Status = Status.IsActive;
        }

        public async Task Delete(int? id)
        {
            var customer = await Get(id);
            customer.Status = Status.IsDeleted;
        }

        public async Task<Customer> Get(int? id)
        {
            return await _context.Customers
                .Include(c => c.City)
                .Include(c => c.Phones.Where(p => p.Status == Status.IsActive))
                .Include(c => c.ConnectedCustomers.Where(cc => cc.Status == Status.IsActive))
                .FirstOrDefaultAsync(c => c.Id == id && c.Status == Status.IsActive);
        }

        public async Task<List<Customer>> GetAll()
        {
            return await _context.Customers
                .Include(c => c.City)
                .Include(c => c.Phones.Where(p => p.Status == Status.IsActive))
                .Include(c => c.ConnectedCustomers.Where(cc => cc.Status == Status.IsActive))
                .Where(x => x.Status == Status.IsActive).ToListAsync();
        }

        public void Update(Customer obj)
        {
            _context.Customers.Update(obj);
        }
    }
}
