using Eticaret.Datta_Access;
using Eticaret.Datta_Access.DbGirişEntitys;
using Eticaret.Datta_Access.DbÜrünEntitys;
using Eticaret.Presentation_Layer.NormalKulalnıcı;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Business_Process_Layer.KullanıcıNınİşlemelri
{
    public class FavorilerimiListele
    {

        

        public static async Task<List<Favori>> Favorilerim(NkKullanıcı kullanıcı)
        {
            EticaretContext context = new();
            
            var data = await context.Favoriler.Include(i=>i.ürün).Where(i => i.NkKullanıcı.Id == kullanıcı.Id).ToListAsync();

            return data;
        }
    }
}
