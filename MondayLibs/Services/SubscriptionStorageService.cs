using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using MondayLibs.Models.Monday;
using Newtonsoft.Json;
using ServiceResult;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MondayLibs.Services
{
    public class SubscriptionStorageService : IStorageService
    {
        readonly IConfiguration _configuration;
        string _storageFile;
        string _storageConnection;

        public SubscriptionStorageService(IConfiguration configuration)
        {
            _configuration = configuration;
            _storageFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), 
                                @$"Store\{_configuration["StorageService:TempSubscriptionStorage"]}");
            _storageConnection = _configuration["StorageService:StorageConnectionString"];
        }
        
        public async Task StoreAsync(Payload payload)
        {
            var strSubsContent = await File.ReadAllTextAsync(_storageFile);
            var subsList = JsonConvert.DeserializeObject<List<Payload>>(strSubsContent);
            subsList.Add(payload);
            strSubsContent = JsonConvert.SerializeObject(subsList, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            using (StreamWriter file = new StreamWriter(_storageFile))
            {
                await file.WriteAsync(strSubsContent);
            }
        }

        public async Task<Result<Payload>> GetAsync(string boardId)
        {
            await DownloadFromBlobStorage();
            var strSubsContent = await File.ReadAllTextAsync(_storageFile);
            var subsList = JsonConvert.DeserializeObject<List<Payload>>(strSubsContent);
            Payload payload = subsList.Find(p => p.InputFields.BoardId.ToString() == boardId);
            return new SuccessResult<Payload>(payload);
        }

        public async Task RemoveAsync(string subscriptionId)
        {
            var strSubsContent = await File.ReadAllTextAsync(_storageFile);
            var subsList = JsonConvert.DeserializeObject<List<Payload>>(strSubsContent);
            Payload payload = subsList.Find(p => p.SubscriptionId.ToString() == subscriptionId || p.WebHookId.ToString() == subscriptionId);
            subsList.Remove(payload);
            strSubsContent = JsonConvert.SerializeObject(subsList, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            using (StreamWriter file = new StreamWriter(_storageFile))
            {
                await file.WriteAsync(strSubsContent);
            }
        }

        public async Task UploadToBlobStorage()
        {
            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(_storageConnection);

            //create a block blob 
            CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();

            //create a container 
            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference("subscription-storage");

            string fileName = Path.GetFileName(_storageFile);

            //get Blob reference
            CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(fileName);
            //cloudBlockBlob.Properties.ContentType = imageToUpload.ContentType;
            using (FileStream fileStream = File.OpenRead(_storageFile))
            {
                await cloudBlockBlob.UploadFromStreamAsync(fileStream);
            }
        }

        public async Task DownloadFromBlobStorage()
        {
            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse(_storageConnection);
            CloudBlobClient blobClient = cloudStorageAccount.CreateCloudBlobClient();

            CloudBlobContainer cloudBlobContainer = blobClient.GetContainerReference("subscription-storage");
            string fileName = Path.GetFileName(_storageFile);
            CloudBlockBlob blockBlob = cloudBlobContainer.GetBlockBlobReference(fileName);
            using (FileStream fileStream = File.OpenWrite(_storageFile))
            {
                fileStream.SetLength(0);
                await blockBlob.DownloadToStreamAsync(fileStream);
            }

        }
    }
}
