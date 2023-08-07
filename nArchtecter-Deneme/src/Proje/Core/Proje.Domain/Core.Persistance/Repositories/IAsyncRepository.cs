using Microsoft.EntityFrameworkCore.Query;
using Proje.Domain.Core.Persistance.Dynamic;
using Proje.Domain.Core.Persistance.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Domain.Core.Persistance.Repositories;

public interface IAsyncRepository<TEntity, TEntityId> : IQuery<TEntity> where TEntity : Entity<TEntityId>
{
    /// <summary>
    /// predicate kesınlıkle gırlımesı ıstenır ve sarta uyan ılk elemanı gonderir
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="include"></param>
    /// <param name="withDeleted"></param>
    /// <param name="enableTracing"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<TEntity?> GetAsync(
        Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, //include işlemini yapmamızı saglıycaktır
        bool withDeleted = false,
        bool enableTracing = true,
        CancellationToken cancellationToken = default
        );
    /// <summary>
    /// bu methot sıze sayfalama yapısını sunar 
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="orderBy"></param>
    /// <param name="include"></param>
    /// <param name="index"></param>
    /// <param name="size"></param>
    /// <param name="withDeleted"></param>
    /// <param name="enableTracing"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Paginate<TEntity?>> GetListAsync(
        Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, //Order by ıslemını yapamamızı saglar
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracing = true,
        CancellationToken cancellationToken = default);
    /// <summary>
    /// Burada dinamik bir sorgu cesıdı kullanıldı bunu ıstersenız o data ılede coze bılrıız meselea dedıkkı sıra name gore asc gibi ve sayfalama yapısı sunar 
    /// </summary>
    /// <param name="dynamic"></param>
    /// <param name="predicate"></param>
    /// <param name="include"></param>
    /// <param name="index"></param>
    /// <param name="size"></param>
    /// <param name="withDeleted"></param>
    /// <param name="enableTracking"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Paginate<TEntity>> GetListByDynamic(
      DynamicQuery dynamic,
      Expression<Func<TEntity, bool>>? predicate = null,
      Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
      int index = 0,
      int size = 10,
      bool withDeleted = false,
      bool enableTracking = true,
      CancellationToken cancellationToken = default);
    /// <summary>
    /// parametrelerle gonderılenlere gore eleman varmı yokmu bool olarak doner
    /// </summary>
    /// <param name="predication"></param>
    /// <param name="withDeleted"></param>
    /// <param name="enableTracing"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> AnyAsync(
        Expression<Func<TEntity, bool>>? predication = null,
        bool withDeleted = false,
        bool enableTracing = true,
        CancellationToken cancellationToken = default);
    /// <summary>
    /// Verilen tek bir elemanı ekler
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<TEntity> AddAsync(TEntity entity);
    /// <summary>
    /// verilen eleman colleksiyonunu ekler
    /// </summary>
    /// <param name="entityes"></param>
    /// <returns></returns>

    Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entityes);
    /// <summary>
    /// tek bır elemanın guncellemenı saglar
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<TEntity> UpdateAsync(TEntity entity);
    /// <summary>
    /// eleman kolecsıyonunu toplu guncellemenı saglar
    /// </summary>
    /// <param name="entityes"></param>
    /// <returns></returns>
    Task<ICollection<TEntity>> UpdateRangeAsync(ICollection<TEntity> entityes);
    /// <summary>
    /// silime işlmeini yapar şöyleki 2 türl üsilme işlemi yapar 1. kalıcı 2. işaretliyerek permanent = false geçici sil demek işaretle
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="permanent"></param>
    /// <returns></returns>
    Task<TEntity> DeleteAsync(TEntity entity, bool permanent = false);//permenent kalıcı demek kalıcı sılınsınmı 
    /// <summary>
    /// Kolleksiyon silime işlmeini yapar şöyleki 2 türl üsilme işlemi yapar 1. kalıcı 2. işaretliyerek permanent = false geçici sil demek işaretle
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="permanent"></param>
    /// <returns></returns>
    Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entityes, bool permanent = false);

}
