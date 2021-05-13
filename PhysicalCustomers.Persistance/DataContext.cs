using Microsoft.EntityFrameworkCore;
using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.PhoneAggregate;

namespace PhysicalCustomers.Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
