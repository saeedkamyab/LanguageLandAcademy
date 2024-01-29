


using Microsoft.AspNetCore.Http;

namespace ZeroFramework.Application.Common
{
    public interface IFileUploader
    {
        string Upload(IFormFile file, string path);
    }
}
