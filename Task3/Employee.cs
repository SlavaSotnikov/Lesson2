using System;

namespace Task3
{
    class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public string Post { get; set; }
        public byte Experience { get; set; }
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public int CalculateTax(int salary)
        {
            return salary * 18 / 100;
        }
        int CalculateSalary(int salary)
        {
            if (Experience < 5)
                return salary + salary * 10 / 100;
            else if (5 <= Experience && Experience < 10)
                return salary + salary * 20 / 100;
            else
                return salary + salary * 30 / 100;
        }
        /*Employee's bonuses:
         * < 5 years experience - 10%
         * of 5 to 10 years     - 20%
         * more then 10 years   - 30%
        */                
        public void ShowSalary()
        {
            int salary;
            switch (Post)
            {
                case "worker":
                    salary = Salary.worker;
                    Console.WriteLine("Salary: {0}, Tax: {1}", CalculateSalary(salary), CalculateTax(salary));
                    break;
                case "engineer":
                    salary = Salary.engineer;
                    Console.WriteLine("Salary: {0}, Tax: {1}", CalculateSalary(salary), CalculateTax(salary));
                    break;
                case "manager":
                    salary = Salary.manager;
                    Console.WriteLine("Salary: {0}, Tax: {1}", CalculateSalary(salary), CalculateTax(salary));
                    break;
            }
        }
    }
}
