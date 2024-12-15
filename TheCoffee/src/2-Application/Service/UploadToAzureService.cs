using Azure.Storage.Blobs;
using TheCoffee.src.Domain.Model.Property;

namespace TheCoffee.src.Application.Service
{
    public class UploadToAzureService
    {
        static string connectionString = "DefaultEndpointsProtocol=https;AccountName=homerent;AccountKey=yYdkERlRNjJgvy7FuIAqRb9QhGdsXbZ9PiKqYqEzcOsC9YMMVX7+Ath0uzSMYDFVRizsyivA9A/j+AStPxGJ1A==;EndpointSuffix=core.windows.net";
        static string containerName = "rootcontainer";

        public static void UploadPhotos(List<Photos> photos, int IdRepository)
        {
            BlobContainerClient containerClient = new(connectionString, containerName);

            foreach (Photos p in photos)
            {
                var filePathOverCloud = $"Homes\'{IdRepository}\'{p.Description}";
                using (MemoryStream stream = new MemoryStream(File.ReadAllBytes("aqui vai o arquivo")))
                {
                    containerClient.UploadBlob(filePathOverCloud, stream);
                }
            }
        }

    }
}
