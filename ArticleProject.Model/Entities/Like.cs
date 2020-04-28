using ArticleProject.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Model.Entities
{
    public class Like: BaseEntity
    {
        public Guid AppUserID { get; set; }
        public virtual AppUser AppUsers { get; set; }

        public Guid BlogID { get; set; }
        public virtual Blog Blogs { get; set; }
    }
}
