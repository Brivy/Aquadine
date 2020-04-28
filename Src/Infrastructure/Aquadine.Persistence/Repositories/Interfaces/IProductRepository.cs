using Aquadine.Domain.Entities;
using System.Collections.Generic;

namespace Aquadine.Persistence.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetActiveProducts();
    }
}
