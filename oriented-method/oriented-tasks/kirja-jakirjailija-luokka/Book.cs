using System;
using System.Collections.Generic;
using System.Text;

namespace kirja_jakirjailija_luokka
{
    class Book
{
    public string Title;
    public string Author;
    public string Publicer;
        private int price;
        public static string Theme;

        public int Price { get => price; set => price = value; } 
         {
       
        public Book()
    {
        Title = "unknown";
        Author = "unknown";
        Publicer = "unknown";
        Price = 0;

    }

    public Book(string title, string author, string publicer, int price, string theme)
    {
        Title = title;
        Author = author;
        Publicer = publicer;
        Price = price;
        Theme = theme;
    }
    public void GetBook(string bookTitle)
    {
        if (Title == bookTitle)
            Console.WriteLine($"Kirja löytyi {Title}, Kirjailija {Author}, Kustantaja {Publicer}, hinta {Price}"); 
    }

        public static void ChangeTheme(string newTheme)
        {
            Theme = newTheme;

        }

        public static 
        { 
            if ( )
 }   
}
