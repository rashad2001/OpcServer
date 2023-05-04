
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OpcServerContext : DbContext
    {

        // for getting ConnectionString from JSON
       public static String get()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("C:\\Users\\Rashad\\source\\repos\\SocarProject\\DataAccess\\dbsettings.json");
          
            IConfiguration config = builder.Build();
            string connectionString = config.GetConnectionString("MySqlConnection");
            return connectionString;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OpcServerContext).Assembly);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(OpcServerContext.get());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
