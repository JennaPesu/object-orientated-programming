using System;

namespace taskperson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Person personJenna = new Person();
            personJenna = "Jenna P";
            Console.WriteLine($"Jennan ikä: {personJenna.GetAge()} ");

            personJenna.GrowOld();
            Console.WriteLine($"Jennan ikä: {personJenna.GetAge()} ");
            personJenna.GrowOld(50);

            personJenna.PrintPersonInfo();


            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();

            Console.ReadKey(); 
        }
    }
}
