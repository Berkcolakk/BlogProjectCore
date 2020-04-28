using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleProject.Model.Entities;
using ArticleProject.Service.Services.LikeServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        ILikeService likeService;
        public LikeController(ILikeService likeService)
        {
            this.likeService = likeService;
        }
        [Route("Insert")]
        public IActionResult Insert(Like like)
        {
            likeService.Insert(like);
            return Ok("Success");
        }
        [Route("Find/{id}")]
        public IActionResult Find(Guid id)
        {
            Like like = likeService.FindById(id);
            return Ok(like);
        }
        [Route("Update")]
        public IActionResult Update(Like like)
        {
            likeService.Update(like);
            return Ok("Success");
        }
        [Route("Delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            likeService.Delete(id);
            return Ok("Success");
        }
    }
}