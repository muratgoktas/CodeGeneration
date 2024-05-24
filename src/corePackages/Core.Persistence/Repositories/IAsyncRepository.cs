using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories;

public interface IAsyncRepository<TEntity,TEntityId> 
    where TEntity:Entity<TEntityId>
{
    Task<TEntity?> GetAsync(
        Expression<Func<TEntity,bool>> predicate,
        Func<IQueryable<TEntity>IIncludable<TEntity,object>>? include =null,


        );
}
