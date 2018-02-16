using System;

namespace kirja_jakirjailija_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book("kirja", "Anton", "Mattel Studios", 20, "komedia");
            newBook.GetBook("kirja");

            Book.ChangeTheme("kauhu");

           
        }
    }
}
