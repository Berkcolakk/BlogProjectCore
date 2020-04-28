using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleProject.Model.Entities;
using ArticleProject.Service.Services.BlogCommentServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCommentController : ControllerBase
    {
        IBlogCommentService blogCommentService;
        public BlogCommentController(IBlogCommentService blogCommentService)
        {
            this.blogCommentService = blogCommentService;
        }
        [Route("Insert")]
        public IActionResult Insert(BlogComment blogComment)
        {
            blogCommentService.Insert(blogComment);
            return Ok("Success");
        }
        [Route("Find/{id}")]
        public IActionResult Find(Guid id)
        {
            BlogComment blogComment = blogCommentService.FindById(id);
            return Ok(blogComment);
        }
        [Route("Update")]
        public IActionResult Update(BlogComment blogComment)
        {
            blogCommentService.Update(blogComment);
            return Ok("Success");
        }
        [Route("Delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            blogCommentService.Delete(id);
            return Ok("Success");
        }
    }
}