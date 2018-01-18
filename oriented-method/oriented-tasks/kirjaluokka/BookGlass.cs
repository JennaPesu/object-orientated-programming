using System;
using System.Collections.Generic;
using System.Text;

namespace kirjaluokka
{
    class Book

    {
     //Fields (Muuttujat) 
     public string Title; 
     public string Author;
     public int Id;
     public double Price; 

     //Constructor (Konstruktori) 
     public Book()
        {
            Title = "unknown";
            Author = "unknown";
            Id = 0;
            Price = 0; 
        }
        public Book(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id; 
            Price = price; 

        } 
        //Methods (Metodit) 
        public void PrintInfo()
        {
            Console.WriteLine($"Kirja {Title}\nKirjailija {Author}\nId {Id}\nHinta {Price} ");
        }
        
        public string CompareBook(Book book)
        {
            if (this.Price > book.Price)
                return $"{this.Title} on kalliimpi kuin {book.Title} kirja";
            else
                return $"{book.Title} on kalliimpi kuin {Title} kirja";  

        }
            public override string ToString()
        {
            var result = $"Kirjan nimi:\t{Title}\n" +
                         $"KIrjoittaja:\t{Author}\n" +
                         $"Id:\\{Id}\n" +
                         $"Hinta:\t{Price}";
            return result; 
        } 
     
    }
}
