using ArticleProject.Dal.Context;
using ArticleProject.Dal.Repository;
using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleProject.Service.Services.BlogServices
{
    public class BlogService : IBlogService
    {
        private IUnitOfWork unitOfWork;
        private IGenericRepository<Blog> blogRepo;
        private BlogManager blogManager;
        private ArticleContext context;

        public BlogService(IGenericRepository<Blog> blogRepo, UnitOfWork unitOfWork, ArticleContext context, BlogManager blogManager)
        {
            this.blogRepo = blogRepo;
            this.unitOfWork = unitOfWork;
            this.context = context;
            this.blogManager = blogManager;
        }
        public bool Delete(Guid id)
        {
            try
            {
                blogRepo.Delete(blogRepo.Get(x => x.ID == id));
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Blog FindById(Guid id)
        {
            try
            {
                return blogRepo.Get(x => x.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Blog> GetAll()
        {
            try
            {
                return blogRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Blog Insert(Blog blog)
        {
            try
            {
                blogRepo.Insert(blog);
                Save();
                return blog;

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

        public bool Update(Blog blog)
        {
            try
            {
                blogRepo.Update(blog);
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
