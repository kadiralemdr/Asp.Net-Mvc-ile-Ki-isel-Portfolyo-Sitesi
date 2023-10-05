using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string NameSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Country { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(150)]
        public string TestimonialContent { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string ImageURL { get; set; }
    }
}