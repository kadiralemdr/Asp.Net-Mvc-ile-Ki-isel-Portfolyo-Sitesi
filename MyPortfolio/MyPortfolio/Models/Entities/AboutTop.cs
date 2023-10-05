using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class AboutTop
    {
        public int AboutTopID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string AdSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Sehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(2)]
        public string Age { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Mail { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Title { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Description { get; set; }
    }
}