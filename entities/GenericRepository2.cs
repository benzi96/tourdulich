using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace entities
{
    public class GenericRepository2<T> : IRepository<T> where T : class
    {
        private tourdulichEntities db = new tourdulichEntities();

        private ObjectContext _context;

        private IObjectSet<T> _objectSet;

        public GenericRepository2(ObjectContext context)
        {
            _context = context;
            _objectSet = _context.CreateObjectSet<T>();
        }

        public GenericRepository2()
        {
            var db = new tourdulichEntities();
            _context = ((IObjectContextAdapter)db).ObjectContext;
            _objectSet = _context.CreateObjectSet<T>();
        }

        public IQueryable<T> GetQuery()
        {
            return _objectSet;
        }

        public IEnumerable<T> GetAll()
        {
            return GetQuery().AsEnumerable();
        }

        public IList<T> GetAll(params string[] navigations)
        {
            IQueryable<T> query = _context.CreateObjectSet<T>();

            foreach (string nav in navigations)
            {
                (query as ObjectQuery<T>).Include(nav);
            }
            return query.ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _objectSet.Where<T>(predicate);
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            return _objectSet.Single<T>(predicate);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return _objectSet.First<T>(predicate);
        }

        public bool Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _objectSet.Attach(entity);
            _objectSet.DeleteObject(entity);
            _context.ObjectStateManager.ChangeObjectState(entity, System.Data.Entity.EntityState.Deleted);
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
            _objectSet.AddObject(entity);
            _context.ObjectStateManager.ChangeObjectState(entity, System.Data.Entity.EntityState.Added);
            
            try
            {
                SaveChanges();
                _objectSet.Attach(entity);
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
            _objectSet.Attach(entity);
            _context.ObjectStateManager.ChangeObjectState(entity, System.Data.Entity.EntityState.Modified);
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
            _context.ObjectStateManager.ChangeObjectState(entity, System.Data.Entity.EntityState.Modified);
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

