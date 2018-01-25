using System;

namespace Työntekijäluokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee työntekijä1 = new Employee("Anton", 1,"Toimitusjohtaja ", 6000);
            Employee työntekijä2 = new Employee("Dan",2, "Myyjä", 5000);
            Employee työntekijä3 = new Employee("Kyle", 3,"Omistaja",7000 );

            työntekijä1.CompareSalary(työntekijä2);
            työntekijä2.CompareSalary(työntekijä3);
            Employee[] employees = new Employee[3];
            employees[0] = työntekijä1;
            employees[1] = new Employee("Heikki", 456, "Kirjailija", 3456);
            employees[2] = työntekijä3;

            for (int i = 0; i < employees.Length; i++)

                employees[i].PrintEmployeeInfo();

            Console.ReadKey(); 
          


        }
    }
}
