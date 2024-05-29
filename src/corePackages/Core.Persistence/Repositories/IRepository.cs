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

public interface IRepository<TEntity, TEntityId>:IQueryable<TEntity>
    where TEntity : Entity<TEntityId>
{
    TEntity? Get(
        Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true
        );

    Paginate<TEntity> GetList(
        Expression<Func<TEntity, bool>>? predicate= null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        int index=0,
        int size =0,
        bool withDeleted = false,
        bool enableTracking = true
        );
    Paginate<TEntity> GetListByDynamic(
        DynamicQuery dynamic,
        Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false, // software silinme olduğu için silinenlerii getirme. true olursa getirir.
        bool enableTracking = true // izleme desteği
        );
    bool Any(Expression<Func<TEntity, bool>>? predicate = null,
          bool withDeleted = false, // software silinme olduğu için silinenlerii getirme. true olursa getirir.
          bool enableTracking = true // izleme desteği
        );
    TEntity Add(TEntity entity); // Bana bir entity ver kayıt edeyim
    ICollection<TEntity> AddRange(ICollection<TEntity> entities); // bana çoklu entity ver kayıt ediyim.

    TEntity  Update(TEntity entity);

    ICollection<TEntity> UpdateRange(ICollection<TEntity> entity);
    TEntity Delete(TEntity entity, bool permanet = false);// permanet kalıcı olarak sil veya sofr delete yap demek.

    ICollection<TEntity> DeleteRange(ICollection<TEntity> entity, bool permanet = false);

}
