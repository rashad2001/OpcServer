using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OpsServerContext : DbContext
    {

        // for getting ConnectionString from JSON
       public static String get()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("C:\\Users\\Rashad\\source\\repos\\SocarProject\\WebApi\\appsettings.json");
            IConfiguration config = builder.Build();
            string connectionString = config.GetConnectionString("MySqlConnection");
            return connectionString;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(25)");
                entity.Property(x => x.Email).IsRequired().HasColumnType("nvarchar(25)");

            });

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(OpsServerContext.get());
        }

        public DbSet<User> Users { get; set; }
    }
}
