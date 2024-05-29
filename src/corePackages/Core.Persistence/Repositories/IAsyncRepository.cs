using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories;

public interface IAsyncRepository<TEntity,TEntityId>:IQueryable<TEntity>
    where TEntity:Entity<TEntityId>
{
    Task<TEntity?> GetAsync(
        Expression<Func<TEntity,bool>> predicate,
        Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>? include =null,
        bool withDeleted = false, // software silinme olduğu için silinenlerii getirme. true olursa getirir.
        bool enableTracking =true, // izleme desteği
        CancellationToken cancellationToken = default
        );
    Task<Paginate<TEntity>> GetListAsync(
        Expression<Func<TEntity, bool>>? predicate =null, // predicate bana şu dataları getir demek.
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy= null, // orderby yapıyoruz
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity,object>>? include = null,
        int index=0,
        int size=10,
        bool withDeleted = false, // software silinme olduğu için silinenlerii getirme. true olursa getirir.
        bool enableTracking = true, // izleme desteği
        CancellationToken cancellationToken = default
        );
    Task<bool> AnyAsync( // bizim aradaığımız veri var mı yok mu ?
        Expression<Func<TEntity,bool>>? predicate = null,
        bool withDeleted = false, // software silinme olduğu için silinenlerii getirme. true olursa getirir.
        bool enableTracking = true, // izleme desteği
        CancellationToken cancellationToken = default
        );
    // dinamik sorgulama...
    Task<Paginate<TEntity>> GetListByDynamicAsync(
        DynamicQuery dynamic, //link üzerinden query oluşturma
        Expression<Func<TEntity,bool>>? predicate = null,
        Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false, // software silinme olduğu için silinenlerii getirme. true olursa getirir.
        bool enableTracking = true, // izleme desteği
        CancellationToken cancellationToken = default

        );

   
    Task<TEntity> AddAsync(TEntity entity); // Bana bir entity ver kayıt edeyim

    Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entities); // bana çoklu entity ver kayıt ediyim.
    Task<TEntity> UpdateAsync(TEntity entity); 

    Task<ICollection<TEntity>> UpdateRangeAsync(ICollection<TEntity> entity);
    Task<TEntity> DeleteAsync(TEntity entity,bool permanet = false);// permanet kalıcı olarak sil veya sofr delete yap demek.

    Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entity,bool permanet = false);



}
