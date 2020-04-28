using Microsoft.EntityFrameworkCore;
using System;

namespace Aquadine.Persistence.Interfaces
{
    internal interface IDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        int SaveChanges();
    }
}
