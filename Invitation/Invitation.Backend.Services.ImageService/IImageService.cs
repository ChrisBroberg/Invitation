using Azure.Storage.Blobs.Models;

namespace Invitation.Backend.Services.ImageService
{
    public interface IImageService
    {
        Task<BlobDownloadResult> GetImage(string blobid, string container);
    }
}