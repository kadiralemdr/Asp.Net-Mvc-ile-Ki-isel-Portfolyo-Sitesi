using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class SkillDescription
    {
        [Key]
        public int SkillDexcriptionID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(150)]
        public string SkillDesTitle { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string Description { get; set; }
    }
}