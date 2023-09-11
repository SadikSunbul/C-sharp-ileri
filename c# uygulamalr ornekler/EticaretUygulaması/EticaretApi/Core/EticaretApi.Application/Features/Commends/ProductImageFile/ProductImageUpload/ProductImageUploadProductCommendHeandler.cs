using EticaretApi.Application.Abstractions.Storage;
using EticaretApi.Application.Repositories;

using EticaretApi.Domain.Entities._File;
using EticaretApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EticaretApi.Application.Features.Commends.ProductImageFile.ProductImageUpload;

namespace EticaretApi.Application.Features.Commends._Product.ProductImageUpload
{
    public class ProductImageUploadProductCommendHeandler : IRequestHandler<ProductImageUploadProductCommendRequest, ProductImageUploadProductCommendResponse>
    {
        private readonly IStorageService storageService;
        private readonly IProductImageWriteRepository productImageWriteRepository;
        private readonly IProductReadRepository productReadRepository;
        public ProductImageUploadProductCommendHeandler(IStorageService storageService, IProductImageWriteRepository productImageWriteRepository, IProductReadRepository productReadRepository)
        {
            this.storageService = storageService;
            this.productImageWriteRepository = productImageWriteRepository;
            this.productReadRepository = productReadRepository;
        }


        public async Task<ProductImageUploadProductCommendResponse> Handle(ProductImageUploadProductCommendRequest request, CancellationToken cancellationToken)
        {


            #region tEST
            var data = await storageService.UploadAsync("resource/files", request.files);
            //  var data =fileService.UploadAsync("resource/product-images", file);
            //  data.Wait();
            //  var data1 = data.Result;
            await productImageWriteRepository.AddRangeAsync(data.Select(d => new EticaretApi.Domain.Entities._File.ProductImageFile()
            {
                FileName = d.fileName,
                Path = d.pathOrContainerName,
                Storage = storageService.StorageName
            }).ToList());
            await productImageWriteRepository.SaveAsync();
            #endregion
            List<(string filename, string pathcontaınernaem)> result = await storageService.UploadAsync("photo-images", request.files);
            Product product = await productReadRepository.GetByIdAsync(request.ProductId);
            //foreach (var r in result)
            //{
            //    product.ProductImageFiles.Add(new (){
            //        FileName = r.filename,
            //        Path = r.pathcontaınernaem,
            //        Storage = storageService.StorageName,
            //        Products = new List<Product>() { product }
            //    });
            //}
            await productImageWriteRepository.AddRangeAsync(result.Select(r => new EticaretApi.Domain.Entities._File.ProductImageFile
            {
                FileName = r.filename,
                Path = r.pathcontaınernaem,
                Storage = storageService.StorageName,
                Products = new List<Product>() { product }
            }).ToList());

            var cıktı = await productImageWriteRepository.SaveAsync();
            if (cıktı > 0)
            {
                return new() { Upload = true };
            }
            else
            {
                return new() { Upload = false };
            }

        }

    }

}


