using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models.Entities
{
    public class Context : DbContext
    {
        public virtual DbSet<AboutTop> AboutTops { get; set; }
        public virtual DbSet<Achievement> Achievements { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<GetTouch> GetTouches { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Portfol> Portfols { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SkillDegree> SkillDegrees { get; set; }
        public virtual DbSet<SkillDescription> SkillDescriptions { get; set; }
        public virtual DbSet<Social> Socials { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<WhoAmI> WhoAmIs { get; set; }
        public virtual DbSet<Yorumlar> Yorumlars { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
    }
}