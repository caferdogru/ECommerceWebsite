using DataAccess.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BCrypt.Net;

namespace DataAccess.Concrete
{
    public class UserRepository:CrudRepository<User>, IUserRepository
    {
        private ECommerceDbContext _context;

        public UserRepository(ECommerceDbContext dbContext ) : base(dbContext)
        {
            _context = dbContext;
        }

        public bool login(string email, string password)
        {
            User user = _context.Users.Where(u => u.Email == email).FirstOrDefault();
            if(user.verifyPassword(password) == true)
            {
                return true;
            }
            return false;
        }

    }
}
