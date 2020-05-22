using Microsoft.EntityFrameworkCore;
using OrangeTech.DAL.Configurations;
using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.DAL.Context
{
    public class OrangeTechContext : DbContext
    {
        public OrangeTechContext(DbContextOptions<OrangeTechContext> option) 
            :base(option)
        {
        }

        public DbSet<Work> Works { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Service> Services { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
