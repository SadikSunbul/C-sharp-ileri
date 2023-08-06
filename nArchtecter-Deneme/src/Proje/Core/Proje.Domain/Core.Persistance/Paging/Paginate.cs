using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Persistance.Paging;

public class Paginate<TEntity>
{
    public Paginate()
    {
        Items = new List<TEntity>();
    }
    public int Size { get; set; }
    public int Index { get; set; }
    public int Count { get; set; }
    public int Page { get; set; }
    public List<TEntity> Items { get; set; }
    public bool HasPrevius => Index > 0;
    public bool HasNext => Index + 1 < Page;
}
