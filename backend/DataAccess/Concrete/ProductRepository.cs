using DataAccess.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProductRepository:CrudRepository<Product>, IProductRepository
    {
        private ECommerceDbContext _context;

        public ProductRepository(ECommerceDbContext dbContext ) : base(dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Product> GetProductByCategory(int categoryId)
        {
            return _context.Products.Where(p => p.Category == categoryId);
        }
    }
}
