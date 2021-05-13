using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Persistance
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Customers.Any()) return;

            var cities = new List<City>
            {
                new City
                {
                    Name="Tbilisi"
                },

                new City
                {
                    Name="Batumi"
                },

                new City
                {
                    Name="Telavi"
                },

                new City
                {
                    Name="Akhaltsikhe"
                },

                new City
                {
                    Name="London"
                },

                new City
                {
                    Name="Moscow"
                },
            };

            await context.Cities.AddRangeAsync(cities);
            await context.SaveChangesAsync();
        }
    }
}
