using Restorant.Application.ViewModel._Basket;
using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.Repositorys._Basket
{
    public interface IBasketWriteRepository:IWriteRepository<Basket>
    {
        Task<List<VM_Basket_List>> basket_Lists(Customer cutomer);
    }
}
