using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        virtual public DateTime UpdateDate { get; set; } //ezıle bılır yaptık fıle ıslemlerınde guncelleme kısmını tutmıycagımız ıcın orada ezıcez bunu 

    }
}
