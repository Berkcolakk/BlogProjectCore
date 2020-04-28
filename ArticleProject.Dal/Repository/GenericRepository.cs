using ArticleProject.Dal.Context;
using ArticleProject.Dal.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ArticleProject.Dal.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ArticleContext _context;
        private DbSet<T> _entities;
        protected IDatabaseFactory DatabaseFactory { get; private set; }
        public GenericRepository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected ArticleContext DataContext
        {
            get { return _context ?? (_context = DatabaseFactory.Get()); }
        }

        public virtual IQueryable<T> Table => this.Entities;

        public virtual IQueryable<T> TableNoTracking => this.Entities.AsNoTracking();

        protected virtual DbSet<T> Entities => _entities ?? DataContext.Set<T>();

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return this.Entities.Where(predicate).SingleOrDefault();
        }

        public virtual T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate)
        {
            return this.Entities.Where(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return this.Entities.ToList();
        }

        public virtual void Insert(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");
                this.Entities.Add(entity);
            }
            catch (Exception dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }

        public virtual void Insert(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");

                foreach (var entity in entities)
                    this.Entities.Add(entity);
            }
            catch (Exception dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");
                this.Entities.Attach(entity);
                DataContext.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }

        public virtual void Update(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");

                foreach (var entity in entities)
                {
                    this.Entities.Attach(entity);
                    DataContext.Entry(entity).State = EntityState.Modified;
                }

            }
            catch (Exception dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }

        public virtual void Update(T entity, params Expression<Func<T, object>>[] noUpdateProperties)
        {
            this.Entities.Attach(entity);
            DataContext.Entry(entity).State = EntityState.Modified;

            foreach (var property in noUpdateProperties)
            {
                DataContext.Entry(entity).Property(property).IsModified = false;
            }
        }

        public virtual void Delete(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");
                DataContext.Remove(entity);
            }
            catch (Exception dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }

        public virtual void Delete(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");
                foreach (var entity in entities)
                {
                    this.Entities.Attach(entity);
                    DataContext.Entry(entity).State = EntityState.Modified;
                }
            }
            catch (Exception dbEx)
            {
                throw new Exception(dbEx.Message);
            }
        }
    }

}
