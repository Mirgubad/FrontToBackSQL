﻿using Microsoft.EntityFrameworkCore;
using front_to_back.Models;
namespace front_to_back.DAL
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<RecentWorkComponent> RecentWorkComponents { get; set; }
        public DbSet<ProjectComponent> ProjectComponents { get; set; }
        public DbSet<ContractIntroComponent> ContractIntroComponent { get; set; }
        public DbSet<CreateWithUs> CreateWithUs { get; set; }
        public DbSet<ContactFormComponent> ContactFormComponents { get; set; }  



    }
}
