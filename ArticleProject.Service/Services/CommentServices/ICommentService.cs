using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service.Services.CommentServices
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        Comment Insert(Comment comment);
        Comment FindById(Guid id);
        bool Update(Comment comment);
        bool Delete(Guid id);
        void Save();
    }
}
