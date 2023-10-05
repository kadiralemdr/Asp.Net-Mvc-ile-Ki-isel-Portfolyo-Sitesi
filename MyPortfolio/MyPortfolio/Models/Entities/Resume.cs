using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Resume
    {
        [Key]
        public int ResumeID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Title1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(150)]
        public string Title2 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Description { get; set; }
    }
}