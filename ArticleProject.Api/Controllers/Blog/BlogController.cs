using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleProject.Model.Entities;
using ArticleProject.Service.Services.BlogServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        IBlogService blogService;
        public BlogController(IBlogService blogService)
        {
            this.blogService = blogService;
        }

        /*
       *  localhost:port/api/Blog/Insert      
       * I tested it on postman and put the object in raw
       * Example Json:
       * {
       "Header":"Test",
       "Description":"Test",
       "Content":"Test",
       "Image":"Test",
       "Homepage":true,
       "Confirmation":true,
       "ReadNumber":0,
       "UsersID":"18DBE0B8-0F3F-408F-BB36-08D7EBC2AC6F",
       "CategoryID":"15D5D79F-3A7E-41D7-23AE-08D7EBC21BC2",
	
    }
       */
        [Route("Insert")]
        public IActionResult Insert(Blog blog)
        {
            blogService.Insert(blog);
            return Ok("Success");
        }
        /*
         *localhost:port/api/Blog/Find/{id}     
         */
        [Route("Find/{id}")]
        public IActionResult Find(Guid id)
        {
            Blog blog = blogService.FindById(id);
            return Ok(blog);
        }
        /*
        *  localhost:port/api/Blog/Insert      
        * I tested it on postman and put the object in raw
        * Example Json:
        * "Header":"Test",
       "Description":"Test",
       "Content":"Test",
       "Image":"Test",
       "Homepage":true,
       "Confirmation":true,
       "ReadNumber":0,
       "UsersID":"18DBE0B8-0F3F-408F-BB36-08D7EBC2AC6F",
       "CategoryID":"15D5D79F-3A7E-41D7-23AE-08D7EBC21BC2",
       "ID":"62700B1D-06E2-4B96-456F-08D7EBC390BC"
        */
        [Route("Update")]
        public IActionResult Update(Blog blog)
        {
            blogService.Update(blog);
            return Ok("Success");
        }
        /*
        *localhost:port/api/Blog/Delete/{id}     
        */
        [Route("Delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            blogService.Delete(id);
            return Ok("Success");
        }
    }
}