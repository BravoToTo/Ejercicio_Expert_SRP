using System;

namespace SRP;

public class Shelves
{
    //public string LibrarySector {get; set;}
    //public string LibraryShelve {get; set;}
    public static void ShelveBook(Book book, string librarysector, string libraryshelve)
    {
        book.LibrarySector = librarysector;
        book.LibraryShelve = libraryshelve;
    }
}