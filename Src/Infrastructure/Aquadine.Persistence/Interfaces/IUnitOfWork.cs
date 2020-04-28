using Aquadine.Persistence.Repositories.Interfaces;

namespace Aquadine.Persistence.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }

        int Complete();
    }
}
