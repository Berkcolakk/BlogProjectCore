﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleProject.Model.Entities;
using ArticleProject.Service.Services.AppUserServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        IAppUserService appUserService;
        public AppUserController(IAppUserService appUserService)
        {
            this.appUserService = appUserService;
        }
        [Route("Insert")]
        /*
         *  localhost:port/api/AppUser/Insert      
         * I tested it on postman and put the object in raw
         * Example Json:
         * {
	    "UserName":"Test",
	    "Password":"123456789",
	    "Address":"TestAddress",
	    "PhoneNumber":"123456789",
	    "ImagePath":"",
	    "Name":"TestName",
	    "LastName":"TestSurname",
	    "Email":"test@test.com.tr"
            }
         */
        public IActionResult Insert([FromBody]AppUser appUser)
        {
            appUserService.Insert(appUser);
            return Ok("Success");
        }
        /*
       *localhost:port/api/AppUser/Find/{id}     
       */
        [Route("Find/{id}")]
        public IActionResult Find(Guid id)
        {
            AppUser appUser = appUserService.FindById(id);
            return Ok(appUser);
        }
        /*
         *  localhost:port/api/AppUser/Insert      
         * I tested it on postman and put the object in raw
         * Example Json:
         * {
        "userName": "TEST",
        "password": "123456789",
        "address": "TEST",
        "phoneNumber": "123456789",
        "imagePath": "",
        "name": "TEST",
        "lastName": "TEST",
        "email": "berkcolak4@gmail.com",
        "birthdate": "0001-01-01T00:00:00",
        "lastLogin": "0001-01-01T00:00:00",
        "commentsID": "00000000-0000-0000-0000-000000000000",
        "likeID": "00000000-0000-0000-0000-000000000000",
        "blogs": [],
        "comments": [],
        "likes": [],
        "id": "16410e28-795b-42d3-7b87-08d7ebbb0af7",
        "createdComputerName": "DESKTOP-R3VKOVJ",
        "createdIp": "",
        "createdDate": "2020-04-29T00:28:11.2003994",
        "createdADUserName": "",
        "modifiedComputerName": null,
        "modifiedIp": null,
        "modifiedDate": "0001-01-01T00:00:00",
        "modifiedADUserName": null
        }
         */
        [Route("Update")]
        public IActionResult Update([FromBody]AppUser appUser)
        {
            appUserService.Update(appUser);
            return Ok("Success");
        }
        /*
         *localhost:port/api/AppUser/Delete/{id}     
         */
        [Route("Delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            appUserService.Delete(id);
            return Ok("Success");
        }
    }
}