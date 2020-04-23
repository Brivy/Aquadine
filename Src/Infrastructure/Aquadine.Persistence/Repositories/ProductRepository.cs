using Aquadine.Domain.Entities;
using Aquadine.Persistence.Interfaces;
using Aquadine.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Aquadine.Persistence.Repositories
{
    internal class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IAquadineContext context) : base(context)
        {

        }

        public IEnumerable<Product> GetActiveProducts()
        {
            return Context.Products.AsNoTracking().Where(x => x.IsActive);
        }
    }
}
