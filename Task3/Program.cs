using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Alaisy", "Magarych");

            Console.WriteLine($"{employee.name} {employee.surname}");
            employee.CalculatedSalary("manager", 5);

            Console.ReadLine();
        }
    }
}
