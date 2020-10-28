using System;

namespace Task3
{
    class Employee
    {
        public string name, surname;
        readonly int workerSalary = 1000;
        readonly int engineerSalary = 2000;
        readonly int managerSalary = 3000;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public int CalculatedTax(int salary)
        {
            return salary * 18 / 100;
        }
        /*Employee's bonuses:
         * < 5 years experience - 10%
         * of 5 to 10 years     - 20%
         * more then 10 years   - 30%
        */
        private int CalculatedWorkerSalary(int experience)
        {
            if (experience < 5)
                return (workerSalary + workerSalary * 10 / 100);
            else if (5 <= experience && experience < 10)
                return (workerSalary + workerSalary * 20 / 100);
            else
                return (workerSalary + workerSalary * 30 / 100);
        }
        private int CalculatedEngineerSalary(int experience)
        {
            if (experience < 5)
                return (engineerSalary + engineerSalary * 10 / 100);
            else if (5 <= experience && experience < 10)
                return (engineerSalary + engineerSalary * 20 / 100);
            else
                return (engineerSalary + engineerSalary * 30 / 100);
        }
        private int CalculatedManagerSalary(int experience)
        {
            if (experience < 5)
                return (managerSalary + managerSalary * 10 / 100);
            else if (5 <= experience && experience < 10)
                return (managerSalary + managerSalary * 20 / 100);
            else
                return (managerSalary + managerSalary * 30 / 100);
        }
        public void CalculatedSalary(string position, int experience)
        {
            switch (position)
            {
                case "worker":                    
                        Console.WriteLine($"Position: {position}, Salary: {CalculatedWorkerSalary(experience)}, " +
                            $"Tax: {CalculatedTax(CalculatedWorkerSalary(experience))}.");
                    break;
                case "engineer":
                    Console.WriteLine($"Position: {position}, Salary: {CalculatedEngineerSalary(experience)}, " +
                        $"Tax: {CalculatedTax(CalculatedEngineerSalary(experience))}.");
                    break;
                case "manager":
                    Console.WriteLine($"Position: {position}, Salary: {CalculatedManagerSalary(experience)}, " +
                        $"Tax: {CalculatedTax(CalculatedManagerSalary(experience))}.");
                    break;
            }
        }
    }
}
