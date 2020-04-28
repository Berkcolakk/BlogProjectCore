using ArticleProject.Dal.Context;
using ArticleProject.Dal.Repository;
using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleProject.Service.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork unitOfWork;
        private IGenericRepository<Category> categoryRepo;
        private CategoryManager categoryManager;
        private ArticleContext context;

        public CategoryService(IGenericRepository<Category> categoryRepo, UnitOfWork unitOfWork, ArticleContext context, CategoryManager categoryManager)
        {
            this.categoryRepo = categoryRepo;
            this.unitOfWork = unitOfWork;
            this.context = context;
            this.categoryManager = categoryManager;
        }
        public bool Delete(Guid id)
        {
            try
            {
                categoryRepo.Delete(categoryRepo.Get(x => x.ID == id));
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Category FindById(Guid id)
        {
            try
            {
                return categoryRepo.Get(x => x.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Category> GetAll()
        {
            try
            {
                return categoryRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Category Insert(Category category)
        {
            try
            {
                categoryRepo.Insert(category);
                Save();
                return category;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Save()
        {
            unitOfWork.Save();
        }

        public bool Update(Category category)
        {
            try
            {
                categoryRepo.Update(category);
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
