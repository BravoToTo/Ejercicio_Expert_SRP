using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");
            // book1.ShelveBook("A", "7");
            // book2.ShelveBook("B", "3");
            Shelves.ShelveBook(book1, "A", "7");
            Shelves.ShelveBook(book2, "B", "3");

             Console.WriteLine(book1.LibrarySector+book1.LibraryShelve);

        }
    }
}