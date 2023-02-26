
    using DataAccess.Abstract;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DataAccess.Concrete
    {
        public class UserBasketRepository:CrudRepository<UserBasket>, IUserBasketRepository
        {
            private ECommerceDbContext _context;

            public UserBasketRepository(ECommerceDbContext dbContext ) : base(dbContext)
            {
                _context = dbContext;
            }

        }
    }


    