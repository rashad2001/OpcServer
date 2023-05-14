// See https://aka.ms/new-console-template for more information
using Core.Entities.Concrete;
using DataAccess;
using System.Text;

Console.WriteLine("Hello, World!");

createDb();

static void createDb()
{
    //using(var ctx = new OpcServerContext())
    //{
       

    //    //ctx.Users.Add(new User { Email = "rasaaaaad@azimov", Name = "Rashad", PasswordHash = Encoding.ASCII.GetBytes("sadasdasd"), PasswordSalt = Encoding.ASCII.GetBytes("asdasdasd") }) ;

    //    //ctx.UserOperationClaims.Add(new UserOperationClaim { OperationClaimId = 2, UserId = 1 });
    //    ctx.SaveChanges();
    //}
}
