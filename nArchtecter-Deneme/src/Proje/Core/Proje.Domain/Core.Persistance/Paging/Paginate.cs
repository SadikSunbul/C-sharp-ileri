using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Persistance.Paging;

/// <summary>
/// İlgili entity için items dahil sayfalama verileri içerir
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public class Paginate<TEntity>
{
    public Paginate()
    {
        Items = new List<TEntity>();
    }
    /// <summary>
    /// sayfa ıcerısındekı eleman sayısı
    /// </summary>
    public int Size { get; set; }
    /// <summary>
    /// kacıncı sayfa 
    /// </summary>
    public int Index { get; set; }
    /// <summary>
    /// toplam eleman 
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// toplam sayfa sayısı
    /// </summary>
    public int Page { get; set; }
    /// <summary>
    /// elemanlar 
    /// </summary>
    public List<TEntity> Items { get; set; }
    /// <summary>
    /// bu sayfanın oncesı varmı 
    /// </summary>
    public bool HasPrevius => Index > 0;
    /// <summary>
    /// bu sayfanın sonrası varmı 
    /// </summary>
    public bool HasNext => Index + 1 < Page;
}
