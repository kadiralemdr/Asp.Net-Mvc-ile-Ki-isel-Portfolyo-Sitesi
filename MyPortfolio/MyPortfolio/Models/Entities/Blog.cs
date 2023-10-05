using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Models.Entities
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Title { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Title1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5000)]
        public string Description { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5000)]
        public string Description1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string ImageURL { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Tarih { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }

    }
}