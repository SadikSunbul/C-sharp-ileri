
using Azure.Storage.Sas;
using EticaretApi.Application.Abstractions.Storage;
using EticaretApi.Application.Features.Commends._Product.CreateProduct;
using EticaretApi.Application.Features.Commends._Product.DeleteProduct;
using EticaretApi.Application.Features.Commends._Product.UpdateProduct;
using EticaretApi.Application.Features.Commends._Product.UploadFilesProduct;
using EticaretApi.Application.Features.Commends.ProductImageFile.ProductImageUpload;
using EticaretApi.Application.Features.Commends.ProductImageFile.RemoveProduct;
using EticaretApi.Application.Features.Queries._Product.GetAllProduct;
using EticaretApi.Application.Features.Queries._Product.GetProductId;
using EticaretApi.Application.Features.Queries.ProductImageFile.GetProductImage;
using EticaretApi.Application.Repositories;
using EticaretApi.Application.RequestParameters;
using EticaretApi.Application.Services;
using EticaretApi.Application.ViewModels.Products;
using EticaretApi.Domain.Entities;
using EticaretApi.Domain.Entities._File;
using EticaretApi.Infrastructure.Services;
using EticaretApi.Infrastructure.Services.Stogare;
using EticaretApi.Persistence.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace EticaretApi.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes="Admin")] //bu controler altındakı ısteklerde yetkılımı yetkısızmı onu kontrol et dedık gelen jwt yı dogrular  Admın ozellestırdıgımız yerden gelrı program cs de hangı profıle uygun olucaksa onu ayarlıyoruz burada
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        /*
         [HttpGet] //bunu drekt bıldırmek gerek degılse swıger patlar
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new (){
            // new (){Id=Guid.NewGuid(), Name="Product 1",Price=100 ,CreateDate=DateTime.Now ,Stock=5},
            // new (){Id=Guid.NewGuid(), Name="Product 2",Price=200 ,CreateDate=DateTime.Now ,Stock=15},
            // new (){Id=Guid.NewGuid(), Name="Product 3",Price=300 ,CreateDate=DateTime.Now ,Stock=25}
            //});
            //await _productWriteRepository.SaveAsync();

            Product p = await _productReadRepository.GetByIdAsync("",false);//2.paramete true deault olarak ıstersen false de yapabılırsın falsede takıp brakılır
            p.Name = "Taha";
            await _productWriteRepository.SaveAsync(); //Burada ıkısı farklı methotlardan gelıyor ama scop olarak dbcontrxt ı IoC kontaınera ekledıgımız ıcın bıze 1 kere olusturcaktır yanı aynı dbcontext te oluyor gıbı bır bırının verılerını kontrol edebılırler 

        }
        [HttpGet("{id}")] //linkdekı ıd yı yakalar
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            _productWriteRepository.AddAsync(new() { Name = "C Product", Price = 1.500F, Stock = 10 });/*,CreateDate=DateTime.Now burayı herzaman yazamayız bunu merkezılestırmek lazım */
        /*
            return Ok(product);
    }

        //[HttpGet]
        //public async Task Test()
        //{
        //    _productWriteRepository.AddAsync(new() { Name = "C Product", Price = 1.500F, Stock = 10 });/*,CreateDate=DateTime.Now burayı herzaman yazamayız bunu merkezılestırmek lazım */
        //}*/




        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest) //[FromQuery] queryden gonderılen datayı yakaladık 
        {
            GetAllProducQueryResponse response = await mediator.Send(getAllProductQueryRequest); //kendısı algılar handlerda ona gore sonucu olusturup degerı gonderırır 
            return Ok(response);
        }


        [HttpGet("[action]/{ProductId}")]
        public async Task<IActionResult> GetId([FromRoute] GetProductIdQueryRequest getProductIdQueryRequest)
        {
            var data = await mediator.Send(getProductIdQueryRequest);
            return Ok(data);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Post(CreateProductCommendRequest createProductCommendRequest) //normalde boyle entıtıy ıle karsılanmaz veri
        {
            var response = await mediator.Send(createProductCommendRequest);

            return StatusCode((int)HttpStatusCode.Created);//ekleme yapıldı kodu doncek 201 doner
        }

        [HttpPut("[action]")]
        public async Task<ActionResult> Put(UpdateProductCommendRequest updateProductCommendRequest) //guncelleme ıslemı yapılcak 
        {
            //if (ModelState.IsValid)
            //{
            //buradakı  calısmaz cunku kendısının yapmıs oldugu default bır dogrulayıcı kontrol sıstemı var orda ılk kontrolu yapar gecebılrıse burayı mesgul eder etmezse drekt hata fırlatır o yapılanamda soyle eklenir
            //builder.Services.AddControllers().AddFluentValidation(configration=>configration.RegisterValidatorsFromAssemblyContaining<CreateProductValidater>())
            //.ConfigureApiBehaviorOptions(option => option.SuppressModelStateInvalidFilter = true);  bu yapılanma yazılırise ılk oto kontrol yapılmaz burası calısır burada manuel bı kotorl ıslemı yapar
            //}
            var veri = await mediator.Send(updateProductCommendRequest);

            return Ok(veri);
        }



        [HttpDelete("[action]")]
        public async Task<IActionResult> Delete(DeletProductCommendRequest deletProductCommendRequest)
        {
            var data = await mediator.Send(deletProductCommendRequest);
            return Ok(data);
        }


        [HttpPost("[Action]")] //Üste post var oldugu ıcın artık ısımı ıle cagrılmalı
        public async Task<IActionResult> Upload([FromQuery] UploadFilesProductCommendRequest uploadFilesProductCommendRequest)
        {
            var data = await mediator.Send(uploadFilesProductCommendRequest);
            return Ok(data);
        }





        [HttpPost("[action]")]
        public async Task<IActionResult> ProductImageUpload([FromQuery]ProductImageUploadProductCommendRequest productImageUploadProduct)
        {
           
            var data = await mediator.Send(productImageUploadProduct);

            return Ok(data);
        }

        [HttpGet("[action]/{Id}")] //ıd yı rout dan alıcaz
        public async Task<IActionResult> GetProductImages([FromRoute] GetProductImageQueryRequest getProductImageQueryRequest)
        {
            var data = await mediator.Send(getProductImageQueryRequest);
            return Ok(data);
        }

        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> DeleteproductImage([FromRoute] RemoveProductCommendRequest removeProductCommendRequest,[FromQuery] string imageId)
        {
            removeProductCommendRequest.ImageId=imageId; //boylede yapıları ayırabılırrız
            var data=await mediator.Send(removeProductCommendRequest);
            return Ok(data);
        }

    }
}
