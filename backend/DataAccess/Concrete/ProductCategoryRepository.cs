using DataAccess.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProductCategoryRepository:CrudRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(ECommerceDbContext dbContext ) : base(dbContext)
        {
            
        }
    }
}
