using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string NameSurname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string SenderMail { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string MessageSubject { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string Content { get; set; }
    }
}