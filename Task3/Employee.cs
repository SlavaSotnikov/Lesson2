using System;

namespace Task3
{
    class Employee
    {
        string name, surname;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public int CalculateTax(Salary.position)
        {
            return Salary.position * 18 / 100;
        }
        /*Employee's bonuses:
         * < 5 years experience - 10%
         * of 5 to 10 years     - 20%
         * more then 10 years   - 30%
        */
        private int CalculateSalary(int experience, string position)
        {
            if (experience < 5)
                return (Salary.position + Salary.position * 10 / 100);
            else if (5 <= experience && experience < 10)
                return (Salary.position + Salary.position * 20 / 100);
            else
                return (Salary.position + Salary.position * 30 / 100);
        }
        
        public void CalculateSalary(string position, int experience)
        {
            switch (position)
            {
                case "worker":                    
                    Console.WriteLine($"Position: {position}, Salary: {CalculateSalary(experience, position)}, " +
                        $"Tax: {CalculateTax(CalculateSalary(experience, position))}.");
                    break;
                case "engineer":
                    Console.WriteLine($"Position: {position}, Salary: {CalculateSalary(experience, position)}, " +
                        $"Tax: {CalculateTax(CalculateSalary(experience, position))}.");
                    break;
                case "manager":
                    Console.WriteLine($"Position: {position}, Salary: {CalculateSalary(experience, position)}, " +
                        $"Tax: {CalculateTax(CalculateSalary(experience, position))}.");
                    break;
            }
        }
    }
}
