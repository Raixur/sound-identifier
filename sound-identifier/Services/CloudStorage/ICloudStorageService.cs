using System.Threading.Tasks;

namespace SoundIdentifier.Services.CloudStorage
{
    public interface ICloudStorageService
    {
        Task UploadAsync(string source, string destination);
        Task DownloadAsync(string source, string destination);    
    }
}