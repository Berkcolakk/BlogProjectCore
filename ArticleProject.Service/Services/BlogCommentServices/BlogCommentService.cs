using ArticleProject.Dal.Context;
using ArticleProject.Dal.Repository;
using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleProject.Service.Services.BlogCommentServices
{
    public class BlogCommentService : IBlogCommentService
    {
        private IUnitOfWork unitOfWork;
        private IGenericRepository<BlogComment> blogRepo;
        private BlogCommentManager blogCommentManager;
        private ArticleContext context;

        public BlogCommentService(IGenericRepository<BlogComment> blogRepo, UnitOfWork unitOfWork, ArticleContext context, BlogCommentManager blogCommentManager)
        {
            this.blogRepo = blogRepo;
            this.unitOfWork = unitOfWork;
            this.context = context;
            this.blogCommentManager = blogCommentManager;
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

        public BlogComment FindById(Guid id)
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

        public List<BlogComment> GetAll()
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

        public BlogComment Insert(BlogComment blogComment)
        {
            try
            {
                blogRepo.Insert(blogComment);
                Save();
                return blogComment;

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

        public bool Update(BlogComment blogComment)
        {
            try
            {
                blogRepo.Update(blogComment);
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
