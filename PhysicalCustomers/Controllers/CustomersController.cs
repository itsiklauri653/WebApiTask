using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PhysicalCustomers.Application.Core.Extensions;
using PhysicalCustomers.Application.Core.Interfaces;
using PhysicalCustomers.Application.Customers;
using PhysicalCustomers.Domain;
using PhysicalCustomers.Domain.AggregatesModel.ConnectedCustomerAggregate;
using System;
using System.Threading.Tasks;
using X.PagedList;

namespace PhysicalCustomers.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly ICityService _cityService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CustomersController(ICityService cityService,
            IWebHostEnvironment webHostEnvironment,
            ICustomerService customerService)
        {
            _customerService = customerService;
            _cityService = cityService;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index(
            string sort,
            string order,
            string pagination,
            string keyword,
            string firstName,
            string lastName,
            string personalId,
            string birthDate,
            string gender,
            string city,
            string phone,
            string connectedCustomer,
            int? page)
        {
            int recordPage = 4;

            if (!page.HasValue)
            {
                page = 1;
                if (string.IsNullOrWhiteSpace(order) || order.Equals("asc"))
                {
                    order = "desc";
                }
                else
                {
                    order = "asc";
                }
            }

            if (!string.IsNullOrWhiteSpace(sort) && !sort.Equals(pagination, StringComparison.CurrentCultureIgnoreCase))
            {
                order = "asc";
            }

            ViewBag.order = order;
            ViewBag.sort = sort;
            ViewBag.keyword = keyword;
            ViewBag.firstName = firstName;
            ViewBag.lastName = lastName;
            ViewBag.personalId = personalId;
            ViewBag.birthDate = birthDate;
            ViewBag.gender = gender;
            ViewBag.city = city;
            ViewBag.phone = phone;
            ViewBag.connectedCustomer = connectedCustomer;

            var customers = await _customerService.GetAll();

            customers = PagingHelpers.Sort(customers, sort, order);

            customers = PagingHelpers.Search(customers, keyword);

            customers = PagingHelpers.Search(customers, firstName, 
                lastName, personalId, birthDate, gender, city, phone, connectedCustomer);

            var finalResult = customers.ToPagedList(page.Value, recordPage);
            return View(finalResult);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _customerService.Get(id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Cities = await _cityService.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                customerViewModel.City = await _cityService.Get(customerViewModel.CityId);
                await _customerService.Create(customerViewModel, _webHostEnvironment.WebRootPath);

                return RedirectToAction(nameof(Index));
            }
            ViewBag.Cities = await _cityService.GetAll();
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _customerService.Get(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewBag.Cities = await _cityService.GetAll();
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CustomerViewModel customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                customer.City = await _cityService.Get(customer.CityId);
                await _customerService.Update(customer, _webHostEnvironment.WebRootPath);

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Cities = await _cityService.GetAll();
            return View(customer);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _customerService.Get(id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _customerService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConnectedCustomer(int fromId, int toId)
        {
            await _customerService.DeleteConnectedCustomer(fromId,toId);

            return RedirectToAction(nameof(Index));
        }
    }
}
