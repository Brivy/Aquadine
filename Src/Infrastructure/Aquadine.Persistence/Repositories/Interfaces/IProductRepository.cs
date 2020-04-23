using Aquadine.Domain.Entities;
using Aquadine.Persistence.Interfaces;
using System.Collections.Generic;

namespace Aquadine.Persistence.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetActiveProducts();
    }
}
