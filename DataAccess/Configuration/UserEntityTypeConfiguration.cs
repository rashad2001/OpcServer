using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.FirstName).IsRequired().HasColumnType("nvarchar(25)");
            entity.Property(x => x.LastName).IsRequired().HasColumnType("nvarchar(25)");
            entity.Property(x => x.Email).IsRequired().HasColumnType("nvarchar(25)");
            entity.Property(x => x.Status).IsRequired().HasColumnType("bit");
            entity.Property(x => x.PasswordHash).IsRequired().HasColumnType("varbinary(255)");
            entity.Property(x => x.PasswordSalt).IsRequired().HasColumnType("varbinary(255)");
        }
    }
}
