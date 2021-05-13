using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
using PhysicalCustomers.Web.Middlewares;
using System;
using System.Reflection;

namespace PhysicalCustomers.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IBaseService<CustomerViewModel>, CustomerService>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<IBaseService<City>, CityService>();
            services.AddTransient<IFileManager, FileManager>();

            AddMediatR(services);
            AddMapper(services);
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("PhysicalCustomerDb"));
            });
            services
                .AddMvcCore(options =>
                {
                    options.Filters.Add<ValidateAttribute>();
                })
                .AddFluentValidation();

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddTransient<IValidator<CustomerViewModel>, CustomerViewModelValidator>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            //app.UseMiddleware<AppExceptionsMiddleware>();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void AddMapper(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CustomerMappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        private void AddMediatR(IServiceCollection services)
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                services.AddMediatR(assembly);
            }
        }
    }
}
