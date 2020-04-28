using ArticleProject.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Model.Entities
{
    public class Comment : BaseEntity
    {
        public Comment()
        {
            BlogComments = new List<BlogComment>();
        }
        public string Body { get; set; }

        public Guid BlogID { get; set; }
        public Guid AppUsersID { get; set; }
        public virtual AppUser AppUsers { get; set; }
        public virtual ICollection<BlogComment> BlogComments { get; set; }
    }
}
