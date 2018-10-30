using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IRepository<T> where  T : class
    {
        bool Insert(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        IQueryable<T> GetAll();
        T GetByID(int ID);
    }
}
