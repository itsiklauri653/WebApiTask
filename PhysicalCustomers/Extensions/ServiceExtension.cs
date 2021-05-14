using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhysicalCustomers.Application.Core.Implementations;
using PhysicalCustomers.Application.Core.Interfaces;
using PhysicalCustomers.Application.Customers;
using PhysicalCustomers.Domain;
using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using PhysicalCustomers.Persistance;
using PhysicalCustomers.Persistance.Repositories;
using PhysicalCustomers.Persistance.UnitOfWork;
using PhysicalCustomers.Web.Filters;

namespace PhysicalCustomers.Web.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllersWithViews();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IBaseService<CustomerViewModel>, CustomerService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IBaseService<City>, CityService>();
            services.AddScoped<IFileManager, FileManager>();

            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("PhysicalCustomerDb"));
            });
            services
                .AddMvcCore(options =>
                {
                    options.Filters.Add<ValidateAttribute>();
                })
                .AddFluentValidation();

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IValidator<CustomerViewModel>, CustomerViewModelValidator>();

            return services;
        }
    }
}
