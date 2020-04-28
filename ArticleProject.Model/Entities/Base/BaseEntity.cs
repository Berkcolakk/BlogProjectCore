using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArticleProject.Model.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        //Eklenmeler
        public string CreatedComputerName { get; set; }
        public string CreatedIp { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedADUserName { get; set; }
        //Güncellemeler
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedADUserName { get; set; }
    }
}
