using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class WhoAmI
    {
        [Key]
        public int WhoID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string Title { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Description { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string CvLink { get; set; }
    }
}