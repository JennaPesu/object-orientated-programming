using System;
using System.Collections.Generic;
using System.Text;

namespace taskperson
{
    class Person
    {
    //Fields (Muuttujat)
    public string name;
    public int age; 
    //Constructor (Konstruktori) 
    public Person()
    {
        name = "uknown";
        age = 0; 
    } 
    public Person(string Name, int age)
    {
        name = Name;
        this.age = age; 
    } 
     //Methods (Metodit) 
    public void GrowOld()
    {
        this.age++; 
    } 
    public void GrowOld(int number)
    {
        this.age = this.age + number; 
    } 
    public void PrintPersonInfo()
    {
        Console.WriteLine($"Nimi: {name}\nIkä: {this.age}\Aikuinen: {IsAdult()} "); 
    } 
    public bool IsAdult()
    {
        return this.age >= 18; 
        //Voit tehdä sen myös näin: 

        /*if (this.age >= 18)
           return true; 
         else 
             return false;*/ 
    } 
    public int GetAge()
    {
        return this.age;
    }


    }
}
