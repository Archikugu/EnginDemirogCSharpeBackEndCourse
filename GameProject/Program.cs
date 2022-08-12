using System;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1999, FirstName = "Gökhan", LastName = "Gök", IdentityNumber = 1234567890 });

            GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager1.Add(new Gamer { Id = 1, BirthYear = 1999, FirstName = "Gökhan", LastName = "Gök", IdentityNumber = 1234567890 });
        }
    }
}
