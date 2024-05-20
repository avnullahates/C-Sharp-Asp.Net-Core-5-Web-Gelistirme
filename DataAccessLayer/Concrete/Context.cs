using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<WriterUser, WriterRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server = 31.186.11.153\\31.186.8.167, 1433; Initial Catalog = CoreProjeDB; Persist Security Info = False; User ID = user23; Password = 123456789aA***+++; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False; Connection Timeout = 30;");

            optionsBuilder.UseSqlServer("Server = 31.186.11.157\\MSSQLSERVER2019, 1433; Initial Catalog = CoreProjeDB; Persist Security Info = False; User ID = user23; Password = 123456789aA***+++; MultipleActiveResultSets = False; Encrypt = False; TrustServerCertificate = False; Connection Timeout = 30;");
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Test1> Test1s { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<WriterMessage> WriterMessages { get; set; }
    }
}
