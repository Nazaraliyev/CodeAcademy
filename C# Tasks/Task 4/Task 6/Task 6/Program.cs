using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee()
            {
                name = "Ad",
                surname = "Soyad",
                position = "Vezife",
                dailySalary = 20
            };

            Console.WriteLine(Emp.monthlySalary(31));
        }
    }

    class Employee
    {
        public string name;
        public string surname;
        public string position;
        public double dailySalary;

        public double monthlySalary(int WorkDayCount)
        {
            return WorkDayCount * dailySalary;
        }
    }
}
