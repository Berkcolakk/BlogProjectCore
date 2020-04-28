using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service.Services.CategoryServices
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Insert(Category category);
        Category FindById(Guid id);
        bool Update(Category category);
        bool Delete(Guid id);
        void Save();
    }
}
