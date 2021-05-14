using PhysicalCustomers.Domain;
using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using PhysicalCustomers.Domain.AggregatesModel.ConnectedCustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.PhoneAggregate;
using PhysicalCustomers.Persistance.Repositories;
using System.Threading.Tasks;

namespace PhysicalCustomers.Persistance.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private ICustomerRepository customerRepository;
        private ICityRepository cityRepository;
        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public ICityRepository CityRepository
        {
            get
            {
                if (cityRepository == null)
                {
                    cityRepository = new CityRepository(_context);
                }
                return cityRepository;
            }
        }

        public IPhoneRepository PhoneRepository { get; }

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new CustomerRepository(_context);
                }
                return customerRepository;
            }
        }

        public IConnectedCustomerRepository ConnectedCustomerRepository { get; }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
