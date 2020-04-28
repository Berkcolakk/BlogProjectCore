using ArticleProject.Dal.Context;
using ArticleProject.Dal.Repository;
using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleProject.Service.Services.LikeServices
{
    public class LikeService : ILikeService
    {
        private IUnitOfWork unitOfWork;
        private IGenericRepository<Like> likeRepo;
        private LikeManager likeManager;
        private ArticleContext context;

        public LikeService(IGenericRepository<Like> likeRepo, UnitOfWork unitOfWork, ArticleContext context, LikeManager likeManager)
        {
            this.likeRepo = likeRepo;
            this.unitOfWork = unitOfWork;
            this.context = context;
            this.likeManager = likeManager;
        }
        public bool Delete(Guid id)
        {
            try
            {
                likeRepo.Delete(likeRepo.Get(x => x.ID == id));
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Like FindById(Guid id)
        {
            try
            {
               return likeRepo.Get(x => x.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Like> GetAll()
        {
            try
            {
                return likeRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public Like Insert(Like like)
        {
            try
            {
                likeRepo.Insert(like);
                Save();
                return like;

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

        public bool Update(Like like)
        {
            try
            {
                likeRepo.Update(like);
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
