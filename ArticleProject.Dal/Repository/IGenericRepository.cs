﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ArticleProject.Dal.Repository
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate);
        T GetById(object id);
        T Get(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Insert(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Update(T entity, params Expression<Func<T, object>>[] noUpdateProperties);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
    }
}
