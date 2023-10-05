using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(150)]
        public string Description { get; set; }
        public DateTime Tarih { get; set; }
    }
}