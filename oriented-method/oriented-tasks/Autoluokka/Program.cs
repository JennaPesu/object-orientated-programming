using System;

namespace Autoluokka
{
    class Program
    {
        static void Main(string[] args)
        { 
            Car auto1 = new Car(); 
            auto1.AskData();
            auto1.ShowCarInfo();
            //Console.WriteLine($"Auton brändi ja nopeus {Car.AskData()} "); 
            Console.ReadLine();
        }
    }
}
