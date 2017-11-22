using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace entities
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        private tourdulichEntities _context;

        private DbSet<T> dbSet;

        public GenericRepository(tourdulichEntities context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public GenericRepository()
        {
            var db = new tourdulichEntities();
            _context = new tourdulichEntities();
            dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetQuery()
        {
            return dbSet;
        }

        public IEnumerable<T> GetAll()
        {
            return GetQuery().AsEnumerable();
        }

        public IList<T> GetAll(params string[] navigations)
        {
            IQueryable<T> query = _context.Set<T>();

            foreach (string nav in navigations)
            {
                query.Include(nav);
            }
            return query.ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where<T>(predicate);
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Single<T>(predicate);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return dbSet.First<T>(predicate);
        }

        public bool Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;
            try
            {
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            dbSet.Add(entity);
            try
            {
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                return false;
            }
        }

        public bool Attach(T entity)
        {
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            try
            {
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            try
            {
                SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}

