using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Alaisy", "Magarych")
            {
                Post = "engineer",
                Experience = 4  //years.
            };

            Console.WriteLine($"{employee.Name} {employee.Surname} {employee.Post.ToUpper()}");
            employee.ShowSalary();

            Console.ReadLine();
        }
    }
}
