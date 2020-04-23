using Aquadine.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Aquadine.Persistence.Repositories
{
    internal abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        protected readonly IAquadineContext Context;

        protected DbSet<TEntity> Set => Context.Set<TEntity>();

        public BaseRepository(IAquadineContext context)
        {
            Context = context;
        }

        public void Add(TEntity entity)
        {
            Set.Add(entity);
        }

        public void Update(TEntity entity)
        {
            Set.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            Set.Remove(entity);
        }
    }
}
