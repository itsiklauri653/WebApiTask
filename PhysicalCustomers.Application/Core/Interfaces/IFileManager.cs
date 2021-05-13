using PhysicalCustomers.Application.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Application.Core.Interfaces
{
    public interface IFileManager
    {
        void UploadFile(CustomerViewModel customer, string webRootPath);
    }
}
