using System;

namespace SRP;

public class ShelveBook
{
    public Book Book {get ;}
    public string LibrarySector {get ;}
    public string LibraryShelve {get ;}
    public ShelveBook(Book book, string librarysector, string libraryshelve)
    {
        this.Book = book;
        this.LibrarySector = librarysector;
        this.LibraryShelve = libraryshelve;
    }
    public void GetInfo()
    {
        Console.WriteLine($"{this.Book.Title} - {this.Book.Author} ({this.Book.Code}) Se encuentra en el sector {this.LibrarySector}, estantería {this.LibraryShelve}");
    }
}