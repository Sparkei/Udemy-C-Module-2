using System;
using System.ComponentModel.Design;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.employeeName = "Mark";
            employee.employeeJob = "Programmer";
            employee.Salary = 1000;
            Console.WriteLine($"Employee is {employee.employeeName} starting salary is {employee.employeeJob} and starting salary {employee.Salary}");
            employee.SayHi();
        }
    }
    struct Employee
    {
        public string employeeName;
        public string employeeJob;
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hello from a struct");
        }
    }
}
