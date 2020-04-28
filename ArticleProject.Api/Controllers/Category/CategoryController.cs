using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleProject.Model.Entities;
using ArticleProject.Service.Services.CategoryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        /*
        *  localhost:port/api/Category/Insert      
        * I tested it on postman and put the object in raw
        * Example Json:
        * {
	            "Name":"Test",
	            "Description":"Test"
            }
        */
        [Route("Insert")]
        public IActionResult Insert(Category category)
        {
            categoryService.Insert(category);
            return Ok("Success");
        }
        /*
      *localhost:port/api/Category/Find/{id}     
      */
        [Route("Find/{id}")]
        public IActionResult Find(Guid id)
        {
            Category category = categoryService.FindById(id);
            return Ok(category);
        }
        /*
         *  localhost:port/api/Category/Insert      
         * I tested it on postman and put the object in raw
         * Example Json:
         * {
	        "Name":"Test2",
	        "Description":"Test2",
	        "ID":"15D5D79F-3A7E-41D7-23AE-08D7EBC21BC2"
            }
         */
        [Route("Update")]
        public IActionResult Update(Category category)
        {
            categoryService.Update(category);
            return Ok("Success");
        }
        /*
        *localhost:port/api/Category/Delete/{id}     
        */
        [Route("Delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            categoryService.Delete(id);
            return Ok("Success");
        }
    }
}