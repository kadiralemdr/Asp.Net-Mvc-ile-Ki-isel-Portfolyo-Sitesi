using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Video
    {
        [Key]
        public int VideoID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(150)]
        public string Title { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Description { get; set; }
        public string VideoFrame { get; set; }
    }
}