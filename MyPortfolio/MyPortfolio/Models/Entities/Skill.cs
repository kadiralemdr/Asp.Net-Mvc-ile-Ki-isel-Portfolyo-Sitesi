using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string SkillName { get; set; }
    }
}