using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        public string Phone { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Mail { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string Adrress { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string NameSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(2)]
        public string Age { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string City { get; set; }
    }
}