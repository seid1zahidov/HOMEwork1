using System;
using HOMEwork.Models;

namespace HOMEwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.books.Add(new Book("Seid", "Zahidov", 101));
            library.books.Add(new Book("Nicat", " Muxtarov", 102));
            //library.FindAllBooksByName("Seid");
            //library.RemoveAllBookByName("Seid");
            library.SearchBooks("Nicat");
            foreach (Book item in library.books)
            {
                Console.WriteLine(item);
            }

        }
    }
}
