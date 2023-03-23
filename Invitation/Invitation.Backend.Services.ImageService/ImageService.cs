using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;

namespace Invitation.Backend.Services.ImageService
{
    public class ImageService : IImageService
    {
        private readonly BlobServiceClient _blobServiceClient;
        public ImageService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }

        public async Task<BlobDownloadResult> GetImage(string blobid, string container)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient(container);
            var blobClient = containerClient.GetBlobClient(blobid);
            return await blobClient.DownloadContentAsync();
        }
    }
}