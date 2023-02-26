
    using DataAccess.Abstract;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DataAccess.Concrete
    {
        public class BasketContentRepository:CrudRepository<BasketContent>, IBasketContentRepository
        {
            private ECommerceDbContext _context;

            public BasketContentRepository(ECommerceDbContext dbContext ) : base(dbContext)
            {
                _context = dbContext;
            }

        }
    }


    