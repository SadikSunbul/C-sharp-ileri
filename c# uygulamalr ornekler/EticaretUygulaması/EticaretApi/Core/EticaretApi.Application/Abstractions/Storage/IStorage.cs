using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Abstractions.Storage
{
    public interface IStorage
    {//en base ınterface mız 
        Task<List<(string fileName, string pathOrContainerName)>> UploadAsync(string pathOrContainerName , IFormFileCollection files);
        Task DeleteAsync(string pathOrContainerName, string fileName);
        List<string> GetFiles(string pathOrContainerName);
        bool HasFiel(string pathOrContainerName,string fileName);
    }
}
