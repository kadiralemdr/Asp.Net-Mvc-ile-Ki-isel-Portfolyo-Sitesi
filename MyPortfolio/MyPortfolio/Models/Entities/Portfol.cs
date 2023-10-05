using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Portfol
    {
        [Key]
        public int PortfolID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string AdSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(150)]
        public string Meslek { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Description { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string ImageURL { get; set; }
    }
}