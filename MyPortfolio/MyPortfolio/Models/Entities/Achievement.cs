using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Achievement
    {
        [Key]
        public int AchievementID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Icon { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(150)]
        public string Title { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Description { get; set; }
    }
}