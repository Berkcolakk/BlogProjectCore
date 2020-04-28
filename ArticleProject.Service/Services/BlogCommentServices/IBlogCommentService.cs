using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service.Services.BlogCommentServices
{
    public interface IBlogCommentService
    {
        List<BlogComment> GetAll();
        BlogComment Insert(BlogComment blogComment);
        BlogComment FindById(Guid id);
        bool Update(BlogComment blogComment);
        bool Delete(Guid id);
        void Save();
    }
}
