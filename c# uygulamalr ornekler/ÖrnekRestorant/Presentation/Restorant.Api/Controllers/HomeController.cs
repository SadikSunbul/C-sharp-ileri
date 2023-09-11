
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Restorant.Application.Repositorys._Basket;
using Restorant.Application.Repositorys._Custoemer;
using Restorant.Application.Repositorys._Food;
using Restorant.Application.Repositorys._Like;
using Restorant.Application.Repositorys._Order;
using Restorant.Application.Repositorys._Payment;
using Restorant.Application.Repositorys._Table;
using Restorant.Application.Repositorys._Worker;
using Restorant.Application.ViewModel._Basket;
using Restorant.Application.ViewModel._Customer;
using Restorant.Application.ViewModel._Like;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Repositorys._Food;
using Restorant.Persistence.Repositorys._Order;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Restorant.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerReadRepository customerReadRepository;
        private readonly ICustomerWriteRepository customerWriteRepository;
        private readonly IWorkerReadRepository workerReadRepository;
        private readonly IWorkerWriteRepository workerWriteRepository;
        private readonly ITableReadRepository tableReadRepository;
        private readonly ITableWriteRepository tableWriteRepository;
        private readonly IFoodReadRepository foodReadRepository;
        private readonly IFoodWriteRepository foodWriteRepository;
        private readonly IBasketReadRepository basketReadRepository;
        private readonly IBasketWriteRepository basketWriteRepository;
        private readonly ILikeReadRepository likeReadRepository;
        private readonly ILikeWriteRepository likeWriteRepository;
        private readonly IPaymentReadRepository paymentReadRepository;
        private readonly IPaymentWriteRepository paymentWriteRepository;
        private readonly IOrderWriteRepository orderWriteRepository;
        private readonly IOrderReadRepository orderReadRepository;

        public HomeController(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository, IWorkerReadRepository workerReadRepository, IWorkerWriteRepository workerWriteRepository, ITableReadRepository tableReadRepository, ITableWriteRepository tableWriteRepository, IFoodReadRepository foodReadRepository, IFoodWriteRepository foodWriteRepository, IBasketReadRepository basketReadRepository, IBasketWriteRepository basketWriteRepository, ILikeReadRepository likeReadRepository, ILikeWriteRepository likeWriteRepository, IPaymentReadRepository paymentReadRepository, IPaymentWriteRepository paymentWriteRepository ,IOrderWriteRepository  orderWriteRepository ,IOrderReadRepository orderReadRepository)
        {
            this.customerReadRepository = customerReadRepository;
            this.customerWriteRepository = customerWriteRepository;
            this.workerReadRepository = workerReadRepository;
            this.workerWriteRepository = workerWriteRepository;
            this.tableReadRepository = tableReadRepository;
            this.tableWriteRepository = tableWriteRepository;
            this.foodReadRepository = foodReadRepository;
            this.foodWriteRepository = foodWriteRepository;
            this.basketReadRepository = basketReadRepository;
            this.basketWriteRepository = basketWriteRepository;
            this.likeReadRepository = likeReadRepository;
            this.likeWriteRepository = likeWriteRepository;
            this.paymentReadRepository = paymentReadRepository;
            this.paymentWriteRepository = paymentWriteRepository;
            this.orderWriteRepository = orderWriteRepository;
            this.orderReadRepository = orderReadRepository;
        }
        string Id = MüşteriGirişsakla.Id;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Kayıt()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Kayıt(VM_Customer_Create customer)
        {
            if (ModelState.IsValid)
            {
                await customerWriteRepository.AddAsync(customer);
                await customerWriteRepository.SaveAsync();
                ViewBag.Hata = "Kayıt Başarılı";
                return RedirectToAction(nameof(NKGiriş));
            }

            return View();
        }



        public IActionResult NKGiriş()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NKGiriş(VM_Customer_Login customer)
        {
            if (ModelState.IsValid)
            {
                var data = await customerReadRepository.GetSingleAsync(i => i.Email == customer.Email && i.Password == customer.Password, false);
                if (data != null)
                {
                    MüşteriGirişsakla.Id = data.Id.ToString();
                    return RedirectToAction(nameof(Yemekler));
                }
                else
                {
                    ViewBag.Hata = "Giriş Başarısız";
                    return View(); //todo buraya bı sayfa atanacak
                }

            }
            ViewBag.Hata = "Giriş Başarısız";
            return View();
        }



        public IActionResult BoşMasalar()
        {
            var data = tableReadRepository.GetAll(false);
            if (data != null)
            {
                ViewBag.Table = data;
            }
            else
            {
                ViewBag.Table = new Table
                {
                    Orders = null,
                    Reservation = false,
                    TableNo = null
                };
            }
            return View();
        }

        public IActionResult Yemekler()
        {
            var data1 = TempData["YemekId"];
            var data2 = TempData["Adet"];
            var data = foodReadRepository.GetAll(false);
            ViewBag.Id = Id;
            if (data != null)
            {
                ViewBag.food = data;
            }
            else
            {
                ViewBag.food = new List<Food>{new Food
                {
                    Name = null,
                    Description = null,
                    Price = 0,
                    Exists = false

                } };
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Sepeteekle(string YemekId, int Adet = 1)
        {
            var data1 = YemekId;
            var data2 = Adet;
            var foot = await foodReadRepository.GetByIdAsync(YemekId);
            Basket basket = new()
            {
                Adet = Adet,
                CustomerId = Guid.Parse(Id),
                Food = foot
            };
            await basketWriteRepository.AddAsync(basket);
            await basketWriteRepository.SaveAsync();
            return RedirectToAction(nameof(Yemekler));
        }


        public async Task<IActionResult> Sepet()
        {
            if (Id == null)
            {
                return View("NKGiriş");
            }
            var customer = await customerReadRepository.GetByIdAsync(Id);
            if (customer == null)
            {
                return View("NKGiriş");
            }

            var data = await basketWriteRepository.basket_Lists(customer);
            ViewBag.sepet = data;

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SepetDelete(Guid BasketId)
        {
            string basketıd = BasketId.ToString();
            if (Id == null)
            {
                return View("NKGiriş");
            }
            var customer = await customerReadRepository.GetByIdAsync(Id);
            if (customer == null)
            {
                return View("NKGiriş");
            }

            await basketWriteRepository.RemoveAsync(basketıd);
            await basketWriteRepository.SaveAsync();

            return RedirectToAction(nameof(Sepet));
        }

        [HttpPost]
        public async Task<IActionResult> LikeAdd(Guid YemekId)
        {

            if (Id == null)
            {
                return View("NKGiriş");
            }
            var customer = await customerReadRepository.GetByIdAsync(Id);
            if (customer == null)
            {
                return View("NKGiriş");
            }
            Like lık = new()
            {
                FoodId = YemekId,
                CustomerId = customer.Id
            };
            await likeWriteRepository.AddAsync(lık);
            await likeWriteRepository.SaveAsync();
            return RedirectToAction(nameof(Yemekler));
        }

        public async Task<IActionResult> LikeListe()
        {

            if (Id == null)
            {
                return View("NKGiriş");
            }
            var customer = await customerReadRepository.GetByIdAsync(Id);
            if (customer == null)
            {
                return View("NKGiriş");
            }

            var data = await likeWriteRepository.like_Lists(customer);

            ViewBag.Likelist = data;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LikeDelete(Guid LikeId)
        {
            if (Id == null)
            {
                return View("NKGiriş");
            }
            await likeWriteRepository.RemoveAsync(LikeId.ToString());
            await likeWriteRepository.SaveAsync();
            return RedirectToAction(nameof(LikeListe));
        }

        [HttpGet]
        public async Task<IActionResult> Siparişler()
        {

            if (Id == null)
            {
                return View("NKGiriş");
            }
            var customer = await customerReadRepository.GetByIdAsync(Id);
            if (customer == null)
            {
                return View("NKGiriş");
            }

            var data = await basketWriteRepository.basket_Lists(customer);
            ViewBag.Likelist = data;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Siparişler(Payment ödeme, double totalfıyat)
        {
            if (Id == null)
            {
                return View("NKGiriş");
            }
            var customer = await customerReadRepository.GetByIdAsync(Id);
            if (customer == null)
            {
                return View("NKGiriş");
            }
            var kontrol=await tableReadRepository.GetSingleAsync(i=>i.TableNo== ödeme.Masano);
            if (kontrol!=null)
            {
                ödeme.CustoemrId = customer.Id;
                ödeme.TotalPrice = totalfıyat;
                var data = await paymentWriteRepository.AddAsync(ödeme);
                var basketlist = await basketReadRepository.GetWhereAsync(i => i.CustomerId == customer.Id);
                var masa = await tableReadRepository.GetSingleAsync(i=>i.TableNo== ödeme.Masano);
                Order order = new();
                order.ActiveOrder = true;
                order.Customer=ödeme.Custoemr;
                order.TableId= masa.Id;
                foreach (var item in basketlist)
                {
                    var fo=await foodReadRepository.GetByIdAsync(item.FoodId.ToString());
                    order.Foods.Add(fo);
                }
                

                var data1 = await orderWriteRepository.AddAsync(order);
                if (data)
                {
                    
                    masa.Reservation = true;
                    await paymentWriteRepository.SaveAsync();
                }
            }
            else
            {
                //MASA REZERVASYONLU YENI BIR MASA SECİN DE
                ViewBag.hata = "Masa rezervasyonlu lutfen baska bır masa secerek deneyiniz";
                return View();
            }
            
            return RedirectToAction(nameof(SiparişTakip));
        }

        //rezervasyonlu masaya kayıt yapılmasın 

        public  async Task<IActionResult> SiparişTakip()
        {
            if (Id == null)
            {
                return View("NKGiriş");
            }
            var customer = await customerReadRepository.GetByIdAsync(Id);
            if (customer == null)
            {
                return View("NKGiriş");
            }

            var data = await orderReadRepository.listele(customer);
            ViewBag.takip = data;
            return View();
        }
    }
}