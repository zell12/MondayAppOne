using MondayLibs.Models.Monday;
using ServiceResult;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MondayLibs.Services
{
    public interface IStorageService
    {
        Task StoreAsync(Payload payload);
        Task<Result<Payload>> GetAsync(string id);
        Task RemoveAsync(string id);
        Task UploadToBlobStorage();
        Task DownloadFromBlobStorage();
    }
}
