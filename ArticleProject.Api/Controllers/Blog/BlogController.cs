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