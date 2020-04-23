using Aquadine.Persistence.Interfaces;
using Aquadine.Persistence.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Aquadine.Persistence
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly IAquadineContext _context;
        private readonly IServiceProvider _serviceProvider;

        private IProductRepository _productRepository;

        public UnitOfWork(IAquadineContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = _serviceProvider.GetRequiredService<IProductRepository>();
                }

                return _productRepository;
            }
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
