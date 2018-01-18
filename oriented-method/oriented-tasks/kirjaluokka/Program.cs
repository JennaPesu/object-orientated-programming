using System;

namespace kirjaluokka
{
    class Program
    {
        static void Main(string[] args)
        {

            Book newBook = new Book("Zax", "Ross", 120, 26.00);
            newBook.PrintInfo();
     
            Book book2 = new Book();
            book2.Price = 10;
            book2.Title = "xxx";
            book2.Id = 1;

            Console.WriteLine(newBook.CompareBook(book2));

            Book book3 = new Book("Testi", "Anton", 100 , 29.90 );
            Console.WriteLine(book2.CompareBook(book3));
            Console.WriteLine(book3.ToString()); 
            Console.ReadKey(); 

        }
    }
}
