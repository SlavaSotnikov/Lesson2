using System;

namespace Task3
{
    class Employee
    {
        // Employee's bonuses:
        const byte bonus1 = 10; // < 5 years experience - 10%
        const byte bonus2 = 20; // of 5 to 10 years     - 20%
        const byte bonus3 = 30; // more then 10 years   - 30%
        
        const byte tax = 18;    // tax index
        const byte index = 100; // percent index

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
            return salary * tax / index;
        }
        int CalculateSalary(int salary)
        {
            if (Experience < 5)
                return salary + salary * bonus1 / index;
            else if (5 <= Experience && Experience < 10)
                return salary + salary * bonus2 / index;
            else
                return salary + salary * bonus3 / index;
        }
        
        public void ShowSalary()
        {
            int salary;
            switch (Post)
            {
                case "worker":
                    salary = Salary.worker;
                    ShowConsol(salary);
                    break;
                case "engineer":
                    salary = Salary.engineer;
                    ShowConsol(salary);
                    break;
                case "manager":
                    salary = Salary.manager;
                    ShowConsol(salary);
                    break;
            }
        }
        void ShowConsol(int salary)
        {
            Console.WriteLine("Salary: {0}, Tax: {1}", CalculateSalary(salary), CalculateTax(salary));
        }
    }
}
