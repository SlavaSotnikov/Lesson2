using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Alaisy", "Magarych");                        
            employee.Post = "engineer";
            employee.Experience = 4;

            Console.WriteLine($"{employee.Name} {employee.Surname} {employee.Post.ToUpper()}");
            employee.ShowSalary();

            Console.ReadLine();
        }
    }
}
