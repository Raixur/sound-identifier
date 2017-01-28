using SoundIdentifier.Services.CloudStorage;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CloudStorageExtension
    {
        public static void AddGoogleCloudStorage(this IServiceCollection services)
        {
            services.AddSingleton<ICloudStorageService, GoogleCloudStorageService>();
        }
    }
}