using ArticleProject.Model.Entities;
using ArticleProject.Model.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleProject.Dal.Context
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options) : base(options) { }
        public ArticleContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.;database=ArticleDB;trusted_connection=true;");
        }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogComment> BlogComment { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Like> Like { get; set; }

        public void Commit()
        {
            this.SaveChanges();
        }
        public override int SaveChanges()
        {
            var Entries = ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            string identity = "";
            string computerName = Environment.MachineName;
            DateTime date = DateTime.Now;
            string ip = "";

            foreach (var item in Entries)
            {
                BaseEntity entity = item.Entity as BaseEntity;
                if (item != null)
                {
                    entity.CreatedADUserName = identity;
                    entity.CreatedComputerName = computerName;
                    entity.CreatedDate = date;
                    entity.CreatedIp = ip;
                }
            }
            return base.SaveChanges();
        }
    }
}
