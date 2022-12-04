using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CrudRepository<T> : ICrudRepository<T> where T : class
    {

        private ECommerceDbContext _context;

        public CrudRepository(ECommerceDbContext dbContext)
        {
            _context = dbContext;
        }
        public T Create(T model)
        {
 
              _context.Set<T>().Add(model);
              _context.SaveChanges();
              return model;
            
        }

        public void Delete(int id)
        {
            T model = Get(id);
            _context.Set<T>().Remove(model);
            _context.SaveChanges();

        }

        public IEnumerable<T> GetAll()
        {


            return _context.Set<T>().AsNoTracking().ToList();
        }

        public T Get(int id)
        {

            return  _context.Set<T>().Find(id);
        }

        public T Update(T model)
        {

            _context.Set<T>().Update(model);
            _context.SaveChanges();
            return model;


        }
    }
}
