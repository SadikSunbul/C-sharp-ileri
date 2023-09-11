using EticaretApi.Application.Services;
using EticaretApi.Infrastructure;
using EticaretApi.Infrastructure.Operations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Infrastructure.Services
{
    public class FileService : IFileService
    {


        public async Task<(string filenme, string path)> UploadAsync(string path, IFormFile file)
        {

            if (file == null || file.Length == 0) //bos ıse cık dedık 
                return ("", "");



            var ext = Path.GetExtension(file.FileName);//dosya yolunun uzantısını (örneğin, ".pdf" gibi) belirlemek için kullanılır
            var filename = Guid.NewGuid().ToString() + ext; //uniq bı ısım olusturduk burada
            var fullPath = Path.Combine("wwwroot", path, filename); //path lerı bırlestırdık 

            if (!Directory.Exists(Path.GetDirectoryName("wwwroot" + path))) //ıcındekı adreste bır dosya varmı dıye bakar yoksa olusturu ıcerıde 
            {
                Directory.CreateDirectory(Path.GetDirectoryName("wwwroot" + path)); //bu dizini olustur dedik

            }

            // Dosyanın bellekteki içeriğini FileStream nesnesine kopyala ve FileStream nesnesiyle dosyayı diskte oluştur.
            using (var stream = new FileStream(fullPath, FileMode.Create))//belirtilen tam dosya yolunda bir FileStream nesnesi oluşturur. "fullPath" değişkeni, oluşturulacak dosyanın tam yolu ve dosya adını içerir. Bu kodda kullanılan FileMode.Create özelliği, var olan bir dosyayı ezer veya var olan bir dosya yoksa yeni bir dosya oluşturur. Yani, bu kod bloğu, belirtilen tam dosya yolunda bir dosya oluşturmak için kullanılabilir. Dosyaya yazılmak istenen veriler daha sonra bu FileStream nesnesi üzerinden aktarılabilir. Bu işlem tamamlandığında, FileStream nesnesi kapatılmalı ve kaynakların serbest bırakılması için Dispose() yöntemi çağrılmalıdır.
            {
                await file.CopyToAsync(stream); //kaydet
                stream.Flush(); //bosalt
            }
            // Kullanıcılara dosyanın erişim yolunu (URL) döndürür.
            var publicPath = Path.Combine("/", path, filename);
            return (filename, publicPath);
        }
    }
}

#region MyRegion
//[HttpPost("[Action]")] //Üste post var oldugu ıcın artık ısımı ıle cagrılmalı
//public async Task<IActionResult> Upload(List<IFormFile> files)
//{
//    string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "resource/product-images");
//    //_webHostEnvironment.WebRootPath wwwroot konumunu veırı sonra ıcerısınde resource/product-images adresını alır 
//    //Path.Combine() yöntemi, belirtilen dizin yollarını birleştirerek tek bir dize oluşturur.
//    if (!Directory.Exists(Path.GetDirectoryName(uploadPath))) //ıcındekı adreste bır dosya varmı dıye bakar yoksa olusturu ıcerıde 
//    {
//        Directory.CreateDirectory(Path.GetDirectoryName(uploadPath)); //bu dizini olustur dedik

//    }
//    foreach (var file in files)
//    {
//        Random r = new();
//        string fileName = Path.GetFileName(file.FileName); //belirtilen dosya yolu dizesinden dosya adını ve uzantısını ayıklar.
//        string fullPath = Path.Combine(uploadPath, $"{r.Next()}{fileName}"); //bırlestırıyoruz 


//        using FileStream fileStream = new(fullPath, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
//        await file.CopyToAsync(fileStream);

//        await fileStream.FlushAsync(); //filetrımı bosaltmak lazım degılse verıelr karısır onu burada bosalttık 


//    }
//    return Ok();
//}

#endregion

