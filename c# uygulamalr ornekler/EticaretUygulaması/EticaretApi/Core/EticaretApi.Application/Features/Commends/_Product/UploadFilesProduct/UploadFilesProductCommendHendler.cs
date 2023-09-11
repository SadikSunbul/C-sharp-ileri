using MediatR;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._Product.UploadFilesProduct
{
    public class UploadFilesProductCommendHendler : IRequestHandler<UploadFilesProductCommendRequest, UploadFilesProductCommendResponse>
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public UploadFilesProductCommendHendler(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        public async Task<UploadFilesProductCommendResponse> Handle(UploadFilesProductCommendRequest request, CancellationToken cancellationToken)
        {
            string uploadPath = Path.Combine(webHostEnvironment.WebRootPath, "resource/product-images");
            //_webHostEnvironment.WebRootPath wwwroot konumunu veırı sonra ıcerısınde resource / product - images adresını alır
            // Path.Combine() yöntemi, belirtilen dizin yollarını birleştirerek tek bir dize oluşturur.
            if (!Directory.Exists(Path.GetDirectoryName(uploadPath))) //ıcındekı adreste bır dosya varmı dıye bakar yoksa olusturu ıcerıde 
            {
                Directory.CreateDirectory(Path.GetDirectoryName(uploadPath)); //bu dizini olustur dedik

            }
            foreach (var file in request.Files)
            {
                Random r = new();
                string fileName = Path.GetFileName(file.FileName); //belirtilen dosya yolu dizesinden dosya adını ve uzantısını ayıklar.
                string fullPath = Path.Combine(uploadPath, $"{r.Next()}{fileName}"); //bırlestırıyoruz 


                using FileStream fileStream = new(fullPath, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
                await file.CopyToAsync(fileStream);

                await fileStream.FlushAsync(); //filetrımı bosaltmak lazım degılse verıelr karısır onu burada bosalttık 
            }
            return new() { Eklendimi = true };
        }
    }
}
