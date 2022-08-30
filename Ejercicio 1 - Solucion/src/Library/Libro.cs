using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ; }
        public Shelves Shelve {get ; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public void ShelveBook(String sector, String shelve)
        {
            this.Shelve.LibrarySector = sector;
            this.Shelve.LibraryShelve = shelve;
        }

    }
}
