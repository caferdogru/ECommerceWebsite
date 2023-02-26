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
        public virtual async Task<T> Create(T model)
        {   
               
             _context.Set<T>().Add(model);
             await  _context.SaveChangesAsync();
             return model;
            
        }

        public virtual void Delete(int id)
        {
            T model = Get(id).Result;
            _context.Set<T>().Remove(model);
            _context.SaveChanges();

        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {

            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<T> Get(int id)
        {

            return await _context.Set<T>().FindAsync(id);
        }

        public virtual async Task<T> Update(T model)
        {

            _context.Set<T>().Update(model);
            await _context.SaveChangesAsync();
            return model;


        }
    }
}
