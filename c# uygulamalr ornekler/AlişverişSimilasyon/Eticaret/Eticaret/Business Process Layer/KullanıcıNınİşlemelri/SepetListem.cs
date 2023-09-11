using Eticaret.Datta_Access.DbGirişEntitys;
using Eticaret.Datta_Access.DbÜrünEntitys;
using Eticaret.Datta_Access;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Eticaret.Business_Process_Layer.KullanıcıNınİşlemelri
{
    public class SepetListem
    {

        public static async Task<List<Sepet>> Sepet(NkKullanıcı kullanıcı)
        {
            EticaretContext context = new();

            var data = await context.Sepetler.Include(i => i.ürün).Where(i => i.NkKullanıcı.Id == kullanıcı.Id).ToListAsync();

            return data;
        }
    }
}
