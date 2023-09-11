using Microsoft.EntityFrameworkCore;
using Restorant.Application.Repositorys;
using Restorant.Application.Repositorys._Order;
using Restorant.Application.ViewModel._Order;
using Restorant.Domain.Entiteis;
using Restorant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Persistence.Repositorys._Order
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        private readonly RestorantDbContext context;

        public OrderReadRepository(RestorantDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<VM_Order_List>> listele(Customer customer)
        {
           var data=await context.Orders.Include(i => i.Foods).Include(i=>i.Table).Where(i => i.Customer.Id==customer.Id).ToListAsync();

            List<VM_Order_List> vm = new();
            foreach (var item in data)
            {
                VM_Order_List l = new();
                l.ActiveOrder = item.ActiveOrder;
                l.İsim = customer.İsim;
                l.Soyisim=customer.Soyisim;
                l.Masano = item.Table.TableNo;
                foreach (var fod in item.Foods)
                {
                    l.FoodName.Add(fod.Name);
                }
                vm.Add(l);
            }

            return vm;
        }
    }
}
