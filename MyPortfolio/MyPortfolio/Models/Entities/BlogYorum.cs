﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}