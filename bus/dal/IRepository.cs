﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Core
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> GetQuery();
        IEnumerable<T> GetAll();
        IList<T> GetAll(params string[] navigations);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T Single(Expression<Func<T, bool>> predicate);
        T First(Expression<Func<T, bool>> predicate);
        bool Add(T entity);
        bool Delete(T entity);
        bool Attach(T entity);
        bool Update(T entity);
        void SaveChanges();
    }
}

