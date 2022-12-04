using DataAccess.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserRepository:CrudRepository<User>, IUserRepository
    {
        public UserRepository(ECommerceDbContext dbContext ) : base(dbContext)
        {
            
        }
    }
}
