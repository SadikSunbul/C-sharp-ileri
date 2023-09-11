using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using EticaretApi.Application.Abstractions.Storage.Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Infrastructure.Services.Stogare.Azure
{
    public class AzureStorage : Storage, IAzureStorage
    {
        readonly BlobServiceClient blobServiceClient; //Azreye baglanmaızı saglar
        BlobContainerClient blobContainerClient; //o acount takı dosya ıslemlerı yapmamıza yarıyor
        public AzureStorage(IConfiguration configuration)
        {
            blobServiceClient= new(configuration["Storage:Azure"]); //buraya baglantı verısı gelmelı oda appsettingjson dan gelıcek
        }
        public async Task DeleteAsync(string ContainerName, string fileName)
        {
            blobContainerClient = blobServiceClient.GetBlobContainerClient(ContainerName);// bu contaınerda calısıcam dedık
            BlobClient blobClient=blobContainerClient.GetBlobClient(fileName);//silinecek dosyanın adı
            await blobClient.DeleteAsync(); //dosyayı sıldık
        }

        public List<string> GetFiles(string ContainerName)
        {
            blobContainerClient=blobServiceClient.GetBlobContainerClient(ContainerName);
            return blobContainerClient.GetBlobs().Select(b => b.Name).ToList();//sadece ısımlerını cektık 
        }

        public bool HasFiel(string ContainerName, string fileName)
        {
            blobContainerClient = blobServiceClient.GetBlobContainerClient(ContainerName);
            return blobContainerClient.GetBlobs().Any(b => b.Name==fileName);//varmı yokmu onun kontrolu any varsa true yoksa false doner
        }

        public async Task<List<(string fileName, string pathOrContainerName)>> UploadAsync(string ContainerName, IFormFileCollection files)
        {
            blobContainerClient =  blobServiceClient.GetBlobContainerClient(ContainerName); //bu contaınerda calısıcam dedık
            await blobContainerClient.CreateIfNotExistsAsync(); //boyle bı contaıner varmı yokmu kontrol ettık  //claut ıcın / yok tur sadece dosya adı olmalı dosya ıcıne dosya felan yok 
            await blobContainerClient.SetAccessPolicyAsync(PublicAccessType.BlobContainer); //erişim izni verdik
            List<(string fileName, string pathOrContainerName)> datas = new();
            foreach (var file in files)
            {
                BlobClient blobClient = blobContainerClient.GetBlobClient(Guid.NewGuid()+file.Name);  //eklenecek dosyanın adı 
                await blobClient.UploadAsync(file.OpenReadStream()); //dosyayı gonderdık
                datas.Add((file.Name,$"{ContainerName}/{file.Name}")); //basını tutmadık onu cekerken verıcez
            }
            return datas;
        }
    }
}
#region MyRegion
//Azurede aynı ısımlı 2 dosya olamaz hata alırız o yuzden ısım degıstırme mekanızmasını eklemek lazım burayada 
#endregion