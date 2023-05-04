// See https://aka.ms/new-console-template for more information
using Core.Entities.Concrete;
using DataAccess;
using System.Text;

Console.WriteLine("Hello, World!");

createDb();

static void createDb()
{
    using(var ctx = new OpcServerContext())
    {
        ctx.Database.EnsureCreated();

        ctx.Users.Add(new User { Email = "rasad@azimov", Name = "Rashad", PasswordHash = Encoding.ASCII.GetBytes("sadasdasd"), PasswordSalt = Encoding.ASCII.GetBytes("asdasdasd") }) ;
       
        ctx.UserOperationClaims.Add(new UserOperationClaim { OperationClaimId = "15", UserId })
        ctx.SaveChanges();
    }
}
