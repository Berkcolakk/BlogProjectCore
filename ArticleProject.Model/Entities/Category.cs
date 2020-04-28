using ArticleProject.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Model.Entities
{
   public class Category : BaseEntity
    {
        public Category()
        {
            Blogs = new List<Blog>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
