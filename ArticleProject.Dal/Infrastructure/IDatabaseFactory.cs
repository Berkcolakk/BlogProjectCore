using ArticleProject.Dal.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Dal.Infrastructure
{
    public interface IDatabaseFactory
    {
        ArticleContext Get();
    }
}
