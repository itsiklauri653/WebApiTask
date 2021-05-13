using Microsoft.EntityFrameworkCore;
using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using PhysicalCustomers.Domain.AggregatesModel.ConnectedCustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.PhoneAggregate;

namespace PhysicalCustomers.Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ConnectedCustomer> ConnectedCustomers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>()
                .HasMany(c => c.ConnectedCustomers)
                .WithOne(cc => cc.CustomerFrom)
                .HasForeignKey(c => c.CustomerFromId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<ConnectedCustomer>()
                .HasOne(c => c.CustomerFrom)
                .WithMany(c => c.ConnectedCustomers)
                .HasForeignKey(c => c.CustomerFromId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
