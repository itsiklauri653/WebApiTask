using PhysicalCustomers.Application.Core.Interfaces;
using PhysicalCustomers.Domain;
using PhysicalCustomers.Domain.AggregatesModel.CityAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalCustomers.Application.Core.Implementations
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Create(City obj)
        {
            _unitOfWork.CityRepository.Create(obj);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task Delete(int? id)
        {
            await _unitOfWork.CityRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<City> Get(int? id)
        {
            return await _unitOfWork.CityRepository.Get(id);
        }

        public async Task<List<City>> GetAll()
        {
            return await _unitOfWork.CityRepository.GetAll();
        }

        public void Update(City obj)
        {
            _unitOfWork.CityRepository.Update(obj);
        }
    }
}
