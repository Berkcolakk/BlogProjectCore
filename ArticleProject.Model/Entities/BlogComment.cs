using ArticleProject.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Model.Entities
{
    public class BlogComment : BaseEntity
    {
        public Guid BlogID { get; set; }
        public Guid CommentID { get; set; }

        public virtual Blog Blogs { get; set; }
        public virtual Comment Comments { get; set; }
    }
}
