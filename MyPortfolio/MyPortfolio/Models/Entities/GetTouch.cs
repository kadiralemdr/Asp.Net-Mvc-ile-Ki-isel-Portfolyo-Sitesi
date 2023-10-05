using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class GetTouch
    {
        [Key]
        public int GetTouchID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Title { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Description { get; set; }
    }
}