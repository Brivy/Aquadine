using Aquadine.Persistence.Interfaces;

namespace Aquadine.Persistence.Repositories
{
    internal abstract class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected readonly IAquadineDbContext Context;

        public Repository(IAquadineDbContext context)
        {
            Context = context;
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }
    }
}
