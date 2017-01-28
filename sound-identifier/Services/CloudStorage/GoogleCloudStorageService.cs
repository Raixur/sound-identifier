using System.IO;
using System.Threading.Tasks;
using Google.Cloud.Storage.V1;

namespace SoundIdentifier.Services.CloudStorage
{
    public class GoogleCloudStorageOptions
    {
        public string ApiKey { get; set; }
        public string ProjectId { get; set; }
        public string BucketName { get; set; }
    }

    public class GoogleCloudStorageService : ICloudStorageService
    {
        GoogleCloudStorageOptions _options;
        private StorageClient _client;
        
        public GoogleCloudStorageService(GoogleCloudStorageOptions options)
        {
            _options = options;
            _client = StorageClient.Create();
        }

        public async Task UploadAsync(string source, string destination)
        {
            // TODO: make content type base on audio file type
            using(var stream = new FileStream(source, FileMode.Open))
            {
                await _client.UploadObjectAsync(_options.BucketName, destination, "audio/mpeg", stream);
            }
        }

        public async Task DownloadAsync(string source, string destination)
        {
            using(var stream = new FileStream(destination, FileMode.Create))
            {
                await _client.DownloadObjectAsync(_options.BucketName, destination, stream);
            }
        }
    }
}