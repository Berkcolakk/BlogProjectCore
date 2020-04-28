using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleProject.Dal.Context;
using ArticleProject.Dal.Infrastructure;
using ArticleProject.Dal.Repository;
using ArticleProject.Service.Services.AppUserServices;
using ArticleProject.Service.Services.BlogCommentServices;
using ArticleProject.Service.Services.BlogServices;
using ArticleProject.Service.Services.CategoryServices;
using ArticleProject.Service.Services.CommentServices;
using ArticleProject.Service.Services.LikeServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ArticleProject.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc(x => x.EnableEndpointRouting = false);

            services.AddDbContext<ArticleContext>(ServiceLifetime.Transient);

            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<AppUserManager>();

            services.AddScoped<IBlogCommentService, BlogCommentService>();
            services.AddScoped<BlogCommentManager>();

            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<BlogManager>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<CategoryManager>();

            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<CommentManager>();

            services.AddScoped<ILikeService, LikeService>();
            services.AddScoped<LikeManager>();

            services.AddScoped<IDatabaseFactory, DatabaseFactory>();
            services.AddScoped<UnitOfWork>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseAuthorization();
            app.UseMvc(routes =>
            {
                //New Route
                routes.MapRoute(
                   name: "about-route",
                   template: "about",
                   defaults: new { controller = "Home", action = "About" }
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //     app.UseEndpoints(endpoints =>
            //     {
            //         endpoints.MapControllerRoute(
            //name: "default",
            //pattern: "api/{controller=Home}/{action=Index}/{id?}");
            //     });
        }
    }
}
