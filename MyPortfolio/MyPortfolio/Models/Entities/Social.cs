using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Social
    {
        [Key]
        public int SocialMediaID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string SocialMediaName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string SocialMediaIcon { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string SocialMediaUrl { get; set; }
    }
}