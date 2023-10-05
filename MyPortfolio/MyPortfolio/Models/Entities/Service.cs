using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string ServiceTitle { get; set; }
        public string ServiceIcon { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string ServiceNumber { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string ServiceContent { get; set; }
    }
}