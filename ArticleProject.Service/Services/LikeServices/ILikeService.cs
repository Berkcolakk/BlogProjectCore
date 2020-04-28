using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service.Services.LikeServices
{
    public interface ILikeService
    {
        List<Like> GetAll();
        Like Insert(Like like);
        Like FindById(Guid id);
        bool Update(Like like);
        bool Delete(Guid id);
        void Save();
    }
}
