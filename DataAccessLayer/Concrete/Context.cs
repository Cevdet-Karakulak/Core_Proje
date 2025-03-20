﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<WriterUser,WriterRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=FLOPPA\\SS17; database=CoroProjeDb; integrated security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experiance> Experiances{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Portfolio> Portfolios{ get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }
        public DbSet<Skill> Skills{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserMessage> UserMessages{ get; set; }
        public DbSet<ToDoList> ToDoLists{ get; set; }
        public DbSet<test1> test1s{ get; set; }
        public DbSet<test2> test2s{ get; set; }
        public DbSet<test3> test3s{ get; set; }
        public DbSet<Announcement> announcements{ get; set; }
        public DbSet<WriterMessage> WriterMessages{ get; set; }
    }
}
