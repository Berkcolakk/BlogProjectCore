using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Dal.Repository
{
    public interface IUnitOfWork
    {
        void Save();
        void SaveWithoutTransaction();
        IGenericRepository<T> GetRepository<T>() where T : class;
        void BeginTransaction(string key);
        void CommitTransaction(string key);
        void RollbackTransaction(string key);
    }
}
