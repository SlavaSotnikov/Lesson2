using Microsoft.OData.Edm;
using System;

namespace Task0
{
    class Program
    {
        static void Main()
        {
            User user = new User()
            {
                Age = 37,
                Login = "123456",
                Name = "Slava",
                Surname = "Sotnikov"
            };
            Console.WriteLine($"Date: {user.dateTime}, Age: {user.Age}, " +
                $"Login: {user.Login}, Name: {user.Name} {user.Surname}.");
            Console.ReadLine();
        }
    }
}
