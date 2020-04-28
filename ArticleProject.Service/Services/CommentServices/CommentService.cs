using ArticleProject.Dal.Context;
using ArticleProject.Dal.Repository;
using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleProject.Service.Services.CommentServices
{
    public class CommentService : ICommentService
    {
        private IUnitOfWork unitOfWork;
        private IGenericRepository<Comment> commentRepo;
        private CommentManager commentManager;
        private ArticleContext context;

        public CommentService(IGenericRepository<Comment> commentRepo, UnitOfWork unitOfWork, ArticleContext context, CommentManager commentManager)
        {
            this.commentRepo = commentRepo;
            this.unitOfWork = unitOfWork;
            this.context = context;
            this.commentManager = commentManager;
        }
        public bool Delete(Guid id)
        {
            try
            {
                commentRepo.Delete(commentRepo.Get(x => x.ID == id));
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Comment FindById(Guid id)
        {
            try
            {
                return commentRepo.Get(x => x.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Comment> GetAll()
        {
            try
            {
                return commentRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Comment Insert(Comment comment)
        {
            try
            {
                commentRepo.Insert(comment);
                Save();
                return comment;

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

        public bool Update(Comment comment)
        {
            try
            {
                commentRepo.Update(comment);
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
