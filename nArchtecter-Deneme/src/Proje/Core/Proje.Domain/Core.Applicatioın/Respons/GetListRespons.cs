using Proje.Domain.Core.Persistance.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Applicatioın.Respons
{
    /// <summary>
    /// Sayfalama işleminden sonra verileri geri dondürmemk için kullanılır
    /// item ve sayfa bılgılerını tutar burası
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class GetListRespons<TEntity> : BasePageModel
    {
        private IList<TEntity> items; 

        public IList<TEntity> Items
        {
            get => items ??= new List<TEntity>(); //item yoksa yeni bos oluştur 
            set => items = value;
        }
    }
}
