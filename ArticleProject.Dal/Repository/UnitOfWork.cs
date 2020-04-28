using ArticleProject.Dal.Context;
using ArticleProject.Dal.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ArticleProject.Dal.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private ArticleContext dataContext;
        private Dictionary<string, IDbContextTransaction> transactions = new Dictionary<string, IDbContextTransaction>();
        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected ArticleContext DataContext
        {
            get
            {
                return dataContext ?? (dataContext = databaseFactory.Get());
            }
        }

        public void Save()
        {
            using (TransactionScope tScope = new TransactionScope())
            {
                DataContext.Commit();
                tScope.Complete();
            }
        }


        public void SaveWithoutTransaction()
        {
            DataContext.Commit();
        }

        public void BeginTransaction(string key)
        {
            var beginTransaction = DataContext.Database.BeginTransaction();
            transactions.Add(key, beginTransaction);
            //DataContext.Database.BeginTransaction();
        }

        public void CommitTransaction(string key)
        {
            //DataContext.Database.CommitTransaction();
            transactions.GetValueOrDefault(key).Commit();
            transactions.Remove(key);
        }

        public void RollbackTransaction(string key)
        {
            //DataContext.Database.RollbackTransaction();
            transactions.GetValueOrDefault(key).Rollback();
            transactions.Remove(key);
        }

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            return new GenericRepository<T>(databaseFactory);
        }

        public async Task BeginTransactionAsync(string key)
        {
            var beginTransaction = await DataContext.Database.BeginTransactionAsync();
            transactions.Add(key, beginTransaction);
        }
    }
}
