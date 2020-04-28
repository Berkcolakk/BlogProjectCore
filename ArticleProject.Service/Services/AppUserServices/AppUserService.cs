using ArticleProject.Dal.Context;
using ArticleProject.Dal.Repository;
using ArticleProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleProject.Service.Services.AppUserServices
{
    public class AppUserService : IAppUserService
    {
        private IUnitOfWork unitOfWork;
        private IGenericRepository<AppUser> userRepo;
        private AppUserManager userManager;
        private ArticleContext context;

        public AppUserService(IGenericRepository<AppUser> userRepo, UnitOfWork unitOfWork, ArticleContext context, AppUserManager userManager)
        {
            this.userRepo = userRepo;
            this.unitOfWork = unitOfWork;
            this.context = context;
            this.userManager = userManager;
        }
        public bool Delete(Guid id)
        {
            try
            {
                userRepo.Delete(userRepo.Get(x => x.ID == id));
                Save();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public AppUser FindById(Guid id)
        {
            try
            {
                return userRepo.Get(x => x.ID == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<AppUser> GetAll()
        {
            try
            {
                return userRepo.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public AppUser Insert(AppUser appUser)
        {
            try
            {
                userRepo.Insert(appUser);
                Save();
                return appUser;

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

        public bool Update(AppUser appUser)
        {
            try
            {
                userRepo.Update(appUser);
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
