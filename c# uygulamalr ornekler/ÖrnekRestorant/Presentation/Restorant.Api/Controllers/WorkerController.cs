using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Restorant.Application.Repositorys._Food;
using Restorant.Application.Repositorys._Order;
using Restorant.Application.Repositorys._Table;
using Restorant.Application.Repositorys._Worker;
using Restorant.Application.ViewModel._Food;
using Restorant.Application.ViewModel._Order;
using Restorant.Application.ViewModel._Table;
using Restorant.Application.ViewModel._Worker;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Repositorys._Worker;
using static NuGet.Packaging.PackagingConstants;

namespace Restorant.Api.Controllers
{

    public class WorkerController : Controller
    {

        public IWorkerReadRepository WorkerReadRepository { get; }
        public IWorkerWriteRepository WorkerWriteRepository { get; }
        public IFoodReadRepository FoodReadRepository { get; }
        public IFoodWriteRepository FoodWriteRepository { get; }
        public ITableWriteRepository TableWriteRepository { get; }
        public ITableReadRepository TableReadRepository { get; }
        public IOrderReadRepository OrderReadRepository { get; }
        public IOrderWriteRepository OrderWriteRepository { get; }

        public WorkerController(IWorkerReadRepository workerReadRepository, IWorkerWriteRepository workerWriteRepository, IFoodReadRepository foodReadRepository, IFoodWriteRepository foodWriteRepository, ITableWriteRepository tableWriteRepository, ITableReadRepository tableReadRepository, IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository)
        {
            WorkerReadRepository = workerReadRepository;
            WorkerWriteRepository = workerWriteRepository;
            FoodReadRepository = foodReadRepository;
            FoodWriteRepository = foodWriteRepository;
            TableWriteRepository = tableWriteRepository;
            TableReadRepository = tableReadRepository;
            OrderReadRepository = orderReadRepository;
            OrderWriteRepository = orderWriteRepository;

        }

        string Id = ÇalişanGirişsaklama.Id;


        public IActionResult CalisanMenü()
        {

            return View();
        }


        public IActionResult YemekEkle()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> YemekEkle(VM_Food_Create food)
        {
            if (Id == null)
            {
                return View("CGiriS");
            }
            var data = await WorkerReadRepository.GetByIdAsync(Id);
            if (data != null)
            {

                if (ModelState.IsValid)
                {
                    await FoodWriteRepository.AddAsync(food);
                    await FoodWriteRepository.SaveAsync();
                    ViewBag.Mesaj = "Ekleme Başarılı";
                }


            }
            else
            {
                ViewBag.Mesaj = "Ekleme Başarısız";
                return View("CGiriS");
            }

            return View();
        }


        public async Task<IActionResult> CGiriS()
        {
            //Worker vork = new()
            //{
            //    Addres = "Konya",
            //    Email = "sadik@gmail.com",
            //    Password = "1",
            //    Name = "Sadık",
            //    Phone = "2345655",
            //    Surname = "Sünbül",
            //    Wage = 999999
            //};

            //await WorkerWriteRepository.AddAsync(vork);
            //await WorkerWriteRepository.SaveAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CGiriS(VM_Worker_Login worker)
        {
            if (ModelState.IsValid)
            {
                var data = await WorkerReadRepository.GetSingleAsync(i => i.Email == worker.Email && i.Password == worker.Password, false);
                if (data != null)
                {
                    ÇalişanGirişsaklama.IdEkle(data.Id.ToString());
                    return RedirectToAction(nameof(Siparişler));

                }
                else
                {
                    ViewBag.Hata = "Giriş Başarısız";
                    return RedirectToAction(nameof(CGiriS));

                }
            }
            ViewBag.Hata = "Giriş Başarısız";
            return RedirectToAction(nameof(CGiriS));

        }


        public IActionResult MasaEkle()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MasaEkle(VM_Table_Create table)
        {
            if (Id == null)
            {
                return RedirectToAction(nameof(CGiriS));

            }
            var data = await WorkerReadRepository.GetByIdAsync(Id);
            if (data != null)
            {

                if (ModelState.IsValid)
                {
                    await TableWriteRepository.AddAsync(table);
                    await TableWriteRepository.SaveAsync();
                    ViewBag.Mesaj = "Ekleme Başarılı";
                }
                else
                {
                    ViewBag.Mesaj = "Ekleme Başarısız";
                }


            }
            else
            {
                return RedirectToAction(nameof(CGiriS));

            }

            return View();
        }


        public IActionResult MasaKontrol()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MasaKontrol(VM_Table_Create table)
        {
            if (Id == null)
            {
                return RedirectToAction(nameof(CGiriS));
            }
            var data = await WorkerReadRepository.GetByIdAsync(Id);
            if (data != null)
            {

                if (ModelState.IsValid)
                {
                    var data1 = await TableReadRepository.GetSingleAsync(i => i.TableNo == table.TableNo);

                    if (data1 != null)
                    {
                        data1.Reservation = false;
                        await TableWriteRepository.SaveAsync();
                        ViewBag.Mesaj = "Rezervasyon iptali Başarılı";
                    }

                }
                ViewBag.Mesaj = "Rezervasyon iptali Başarısız";

            }
            else
            {
                return RedirectToAction(nameof(CGiriS));
            }

            return RedirectToAction(nameof(MasaKontrol));

        }

        public async Task<IActionResult> Siparişler(VM_Order_Create order)
        {
            if (Id == null)
            {
                return View("CGiriS");
            }
            var data = await WorkerReadRepository.GetByIdAsync(Id);
            if (data != null)
            {

                if (ModelState.IsValid)
                {
                    var orders = OrderReadRepository.GetAll();
                    ViewBag.order = orders;
                }

                ViewBag.order = new Order
                {
                    ActiveOrder = false,
                    Foods = null,
                    Table = null
                };
            }
            else
            {
                return RedirectToAction(nameof(CGiriS));
            }
            return View();
        }
        public IActionResult Siparişonayı()
        {

            return View("Siparişler");
        }


    }
}
