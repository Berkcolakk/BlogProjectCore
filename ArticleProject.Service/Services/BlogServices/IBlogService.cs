using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service.Services.BlogServices
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        Blog Insert(Blog blog);
        Blog FindById(Guid id);
        bool Update(Blog blog);
        bool Delete(Guid id);
        void Save();
    }
}
