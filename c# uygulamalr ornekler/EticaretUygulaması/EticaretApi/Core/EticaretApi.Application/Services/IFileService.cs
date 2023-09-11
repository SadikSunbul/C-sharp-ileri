using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Services
{
    public interface IFileService
    {
        Task<(string filenme, string path)> UploadAsync(string path, IFormFile file);
    }
}
