using System;
using System.Collections.Generic;
using System.Text;

namespace Autoluokka
{
    class Car
    {
        //Variables
        public string Brand;
        public int Speed; 

        //Contructor
        public Car()
        {
            Brand = "unknown";
            Speed = 0;  
        } 
        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed; 
        } 

        //Methods
        public void ShowCarInfo()
        {
            Console.WriteLine($"Auto:\nBrändi {Brand}\nNopeus {Speed}s"); 
        } 
        
public void  AskData()
        {
            Console.Write("Anna autonmerkki: ");
            Brand = Console.ReadLine(); 
            Console.Write("Syötä auton nopeus: ");  
             Speed = int.Parse(Console.ReadLine());
        }

    }
}
