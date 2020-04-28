using ArticleProject.Dal.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Dal.Infrastructure
{
    public class DatabaseFactory: Disposable, IDatabaseFactory
    {
        private ArticleContext dataContext;

        public ArticleContext Get()
        {
            return dataContext ?? (dataContext = new ArticleContext());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
