using System;
using System.Collections.Generic;
using System.Text;

namespace Työntekijäluokka
{
    class Employee
    {
        public string Name;
        public int Id;
        public string Position;
        public int Salary; 

        public Employee()
        {
            Name = "unknown";
            Id = 0;
            Position = "unknown";
            Salary = 0; 
        } 

        public Employee(string name, int id, string position, int salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary; 
        } 
        public void CompareSalary(Employee employee)
        {
            if (Salary > employee.Salary)
                Console.WriteLine($"{Name} palkka on suurempi, kuin {employee.Name}");
            else
                Console.WriteLine($"{employee.Name} palkka on suurempi, kuin {Name} ");

        } 
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Työntekijä\nName {Name}\nPalkka {Salary} "); 

        }
    }
}
