using Azure.Storage.Blobs;
using HouseRent.Model;

namespace HouseRent.Services
{
  public class UploadToAzure
    {
        static string connectionString = "DefaultEndpointsProtocol=https;AccountName=homerent;AccountKey=yYdkERlRNjJgvy7FuIAqRb9QhGdsXbZ9PiKqYqEzcOsC9YMMVX7+Ath0uzSMYDFVRizsyivA9A/j+AStPxGJ1A==;EndpointSuffix=core.windows.net";
        static string containerName = "rootcontainer";

        public static void UploadPhotos(List<Photos> photos, int IdRepository)
        {
            BlobContainerClient containerClient = new(connectionString, containerName);

            foreach(Photos p in photos)
            {
                var filePathOverCloud = $"Homes\'{IdRepository}\'{p.Description}";
                using (MemoryStream stream = new MemoryStream(File.ReadAllBytes("aqui vai o arquivo")))
                {
                    containerClient.UploadBlob(filePathOverCloud,stream);
                }
            }   
        }
        
    }
}
