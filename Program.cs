using Azure.Storage.Blobs;
using System.IO;

namespace AzureBlobStorageFileUpload
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var blobStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=blobdemo3;AccountKey=qnRgcW7GeZmMgN9cXqrwhJeZ/wSHsnGrRWon5/AVsp+Ma8PJixi3tNEgaMZnMW6EJcgguSoXYFdz+ASteKlLgg==;EndpointSuffix=core.windows.net";
            var blobStorageConnectionName = "fileupload";

            var container = new BlobContainerClient(blobStorageConnectionString, blobStorageConnectionName);
            var blob = container.GetBlobClient("nature.jpg");
            var stream = File.OpenRead("nature.jpg");
            await blob.UploadAsync(stream);
                Console.WriteLine("Upload Completed.");
            Console.ReadLine();
        }
    }
}