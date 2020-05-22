using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.DAL.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(new Role
            { RoleId = Guid.Parse("88b510f1-ce1f-48ec-a39c-c2da62b41e51"), Name = "Admin" });
            builder.HasData(new Role
            { RoleId = Guid.Parse("b3de9a30-ec07-4f1b-80ee-fc14892e0182"), Name = "Guest" });
        }
    }
}
