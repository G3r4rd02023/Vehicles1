using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Vehicles.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
    }
}
