using Restorant.Application.ViewModel._Like;
using Restorant.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant.Application.Repositorys._Like
{
    public interface ILikeWriteRepository:IWriteRepository<Like>
    {
        Task<List<VM_Like_List>> like_Lists(Customer customer);
    }
    
}
