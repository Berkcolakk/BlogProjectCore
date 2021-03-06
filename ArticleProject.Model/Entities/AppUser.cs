﻿using ArticleProject.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Model.Entities
{
    public class AppUser : BaseEntity
    {
        public AppUser()
        {
            Comments = new List<Comment>();
            Likes = new List<Like>();
            Blogs = new List<Blog>();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime LastLogin { get; set; }
        public Guid CommentsID { get; set; }
        public Guid LikeID { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }

    }
}
