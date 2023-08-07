using Microsoft.EntityFrameworkCore;
using Proje.Domain.Core.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Persistance.Paging;

public static class IQueryablePaginateExtensions
{
    /// <summary>
    /// Sayfalama işlemini gerçekleştiren extenson bır kod dur 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="sourc"></param>
    /// <param name="index"></param>
    /// <param name="size"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<Paginate<TEntity>> ToPaginationAsync<TEntity>(
        this IQueryable<TEntity> sourc,
        int index,
        int size,
        CancellationToken cancellationToken = default
        )
    {
        //buraya gelen verielrin sayısı ne kadardır 
        int count = await sourc.CountAsync(cancellationToken).ConfigureAwait(false);
        //sayfalama ıslemını yapar burası
        List<TEntity> items = await sourc.Skip(index * size).Take(size).ToListAsync(cancellationToken).ConfigureAwait(false);
        //eleman lı bırsekılde sayfa bılgılerını gonderdık 
        Paginate<TEntity> list = new Paginate<TEntity>()
        {
            Index = index,
            Count = count,
            Items = items,
            Size = size,
            Page = (int)Math.Ceiling(count / (double)size)

        };
        return list;
    }
    // ustekı methodun senkron seklıdır 
    public static Paginate<TEntity> ToPagiante<TEntity>(this IQueryable<TEntity> source, int index, int size)
    {
        int count = source.Count();
        var items = source.Skip(index * size).Take(size).ToList();

        Paginate<TEntity> lis = new Paginate<TEntity>()
        {
            Index = index,
            Count = count,
            Size = size,
            Items = items,
            Page = (int)Math.Ceiling(count / (double)size) //sayfa sayısı
        };
        return lis;
    }
}


