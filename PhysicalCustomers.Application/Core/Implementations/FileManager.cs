using PhysicalCustomers.Application.Core.Interfaces;
using PhysicalCustomers.Application.Customers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalCustomers.Application.Core.Implementations
{
    public class FileManager : IFileManager
    {
        public void UploadFile(CustomerViewModel customer, string webRootPath)
        {
            string uploadsFolder = Path.Combine(webRootPath, "images");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + customer.Image.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                customer.Image.CopyTo(fileStream);
            }
            customer.GraphicalData = uniqueFileName;
        }
    }
}
