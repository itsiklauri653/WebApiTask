using PhysicalCustomers.Application.Customers;

namespace PhysicalCustomers.Application.Core.Interfaces
{
    public interface IFileManager
    {
        void UploadFile(CustomerViewModel customer, string webRootPath);
    }
}
