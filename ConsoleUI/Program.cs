// See https://aka.ms/new-console-template for more information
using DataAccess;
using Entities;

Console.WriteLine("Hello, World!");

createDb();

static void createDb()
{
    using(var ctx = new OpsServerContext())
    {
        ctx.Database.EnsureCreated();

        ctx.Users.Add(new User { Name = "Rashad", Email = "azimov@gmail.com" }) ;
        ctx.Users.Add(new User { Name = "Elmir", Email = "elmir@rzayev.com" });
        ctx.SaveChanges();
    }
}
