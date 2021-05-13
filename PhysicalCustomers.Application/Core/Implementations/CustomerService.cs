using AutoMapper;
using PhysicalCustomers.Application.Core.Interfaces;
using PhysicalCustomers.Application.Customers;
using PhysicalCustomers.Domain;
using PhysicalCustomers.Domain.AggregatesModel.BaseAggregate;
using PhysicalCustomers.Domain.AggregatesModel.ConnectedCustomerAggregate;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Application.Core.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;

        public CustomerService(IFileManager fileManager, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _fileManager = fileManager;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddConnectedCustomer(ConnectedCustomer connectedCustomer)
        {
            var customerFrom = await _unitOfWork.CustomerRepository.Get(connectedCustomer.CustomerFromId);
            var customerTo = await _unitOfWork.CustomerRepository.Get(connectedCustomer.CustomerToId);

            customerFrom.ConnectedCustomers.Add(connectedCustomer);
            customerTo.ConnectedCustomers.Add(connectedCustomer);
        }

        public async Task Create(CustomerViewModel obj, string webRoot)
        {
            if (obj.Image != null)
            {
                _fileManager.UploadFile(obj, webRoot);
            }
            var customer = _mapper.Map<Customer>(obj);

            _unitOfWork.CustomerRepository.Create(customer);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task Delete(int? id)
        {
            await _unitOfWork.CustomerRepository.Delete(id);
        }

        public async Task DeleteConnectedCustomer(int? customerFromId, int? customerToId)
        {
            var costumer = await _unitOfWork.CustomerRepository.Get(customerFromId);
            var connectedCustomer = costumer.ConnectedCustomers
                .Where(c => c.CustomerFromId == customerFromId && c.CustomerToId == customerToId)
                .FirstOrDefault();
            connectedCustomer.Status = Status.IsDeleted;
        }

        public async Task<CustomerViewModel> Get(int? id)
        {
            var customer = await _unitOfWork.CustomerRepository.Get(id);

            return _mapper.Map<CustomerViewModel>(customer);
        }

        public async Task<IQueryable<CustomerViewModel>> GetAll()
        {
            var customers = await _unitOfWork.CustomerRepository.GetAll();

            return _mapper.Map<IQueryable<CustomerViewModel>>(customers);
        }

        public async Task<ConnectedCustomer> GetConnectedCustomer(int? fromId, int? toId)
        {
            var customer = await _unitOfWork.CustomerRepository.Get(fromId);
            return customer.ConnectedCustomers.Where(cc => cc.CustomerToId == toId).FirstOrDefault();
        }

        public void Update(CustomerViewModel obj, string webRoot)
        {
            if (obj.Image != null)
            {
                _fileManager.UploadFile(obj, webRoot);
            }
            var customer = _mapper.Map<Customer>(obj);
            _unitOfWork.CustomerRepository.Update(customer);
            _unitOfWork.SaveChangesAsync();
        }
    }
}
