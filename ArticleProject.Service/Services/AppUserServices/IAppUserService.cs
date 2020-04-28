using System;
using System.Collections.Generic;
using System.Text;
using ArticleProject.Model.Entities;

namespace ArticleProject.Service.Services.AppUserServices
{
    public interface IAppUserService
    {
        List<AppUser> GetAll();
        AppUser Insert(AppUser appUser);
        AppUser FindById(Guid id);
        bool Update(AppUser appUser);
        bool Delete(Guid id);
        void Save();
    }
}
