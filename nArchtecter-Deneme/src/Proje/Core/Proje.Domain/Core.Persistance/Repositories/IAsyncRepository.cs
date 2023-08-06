﻿using Microsoft.EntityFrameworkCore.Query;
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
    Task<TEntity?> GetAsync(
        Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool withDeleted = false,
        bool enableTracing = true,
        CancellationToken cancellationToken = default
        );
    Task<Paginate<TEntity?>> GetListAsync(
        Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracing = true,
        CancellationToken cancellationToken = default);

     Task<Paginate<TEntity>> GetListByDynamic(
      DynamicQuery dynamic,
      Expression<Func<TEntity, bool>>? predicate = null,
      Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
      int index = 0,
      int size = 10,
      bool withDeleted = false,
      bool enableTracking = true,
      CancellationToken cancellationToken = default);

    Task<bool> AnyAsync(
        Expression<Func<TEntity, bool>>? predication = null,
        bool withDeleted = false,
        bool enableTracing = true,
        CancellationToken cancellationToken = default);

    Task<TEntity> AddAsync(TEntity entity);

    Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entityes);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task<ICollection<TEntity>> UpdateRangeAsync(ICollection<TEntity> entityes);

    Task<TEntity> DeleteAsync(TEntity entity, bool permanent = false);//permenent kalıcı demek kalıcı sılınsınmı 

    Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entityes, bool permanent = false);

}
