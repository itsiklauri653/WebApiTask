using AutoMapper;
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;
using System.Linq;

namespace PhysicalCustomers.Application.Customers
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<CustomerViewModel, Customer>()
                .ReverseMap()
                .ForMember(cv => cv.Image, c => c.Ignore());
        }
    }
}
