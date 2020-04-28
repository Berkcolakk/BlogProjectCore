using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleProject.Model.Entities;
using ArticleProject.Service.Services.CommentServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        ICommentService commentService;
        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        [Route("Insert")]
        public IActionResult Insert(Comment comment)
        {
            commentService.Insert(comment);
            return Ok("Success");
        }
        [Route("Find/{id}")]
        public IActionResult Find(Guid id)
        {
            Comment comment = commentService.FindById(id);
            return Ok(comment);
        }
        [Route("Update")]
        public IActionResult Update(Comment comment)
        {
            commentService.Update(comment);
            return Ok("Success");
        }
        [Route("Delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            commentService.Delete(id);
            return Ok("Success");
        }
    }
}