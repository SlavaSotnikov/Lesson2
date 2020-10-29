using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Alaisy", "Magarych");

            employee.CalculateSalary("manager", 5); 

            Console.ReadLine();
        }
    }
}
