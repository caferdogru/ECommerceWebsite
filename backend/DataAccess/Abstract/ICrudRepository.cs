using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICrudRepository<T> where T: class
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        T Create(T product);

        T Update(T product);

        void Delete(int id);


    }
}
