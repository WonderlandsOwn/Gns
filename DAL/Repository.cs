using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GnsEntities;

namespace DAL
{
    public class Repository<T> : IRepository<T> where  T : class
    {
        protected DbSet<T> DALSet;
        protected GnsDbContext DALContext;

        public Repository()
        {
            DALContext = new GnsDbContext();
            DALSet = DALContext.Set<T>();
        }

        public bool Insert(T entity)
        {
            try
            {
                DbEntityEntry dbEntityEntry = DALContext.Entry(entity);
                if (dbEntityEntry.State != EntityState.Detached)
                {
                    dbEntityEntry.State = EntityState.Added;
                }
                else
                {
                    DALSet.Add(entity);
                }
                DALContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool Delete(T entity)
        {
            try
            {
                DbEntityEntry dbEntityEntry = DALContext.Entry(entity);
                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                else
                {
                    DALSet.Attach(entity);
                    DALSet.Remove(entity);
                }
                DALContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool Update(T entity)
        {
            try
            {
                DbEntityEntry dbEntityEntry = DALContext.Entry(entity);
                if (dbEntityEntry.State == EntityState.Detached)
                {
                    DALSet.Attach(entity);
                }
                dbEntityEntry.State = EntityState.Modified;
                DALContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public IQueryable<T> GetAll()
        {
            return DALSet;
        }

        public T GetByID(int ID)
        {
            return DALSet.Find(ID);
        }
    }
}
