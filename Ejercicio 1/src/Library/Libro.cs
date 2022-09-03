using System;

namespace SRP
{
    public class Book
    {
        /*
        La clase libro solo necesita saber de la información del libro. No le importa
        en que sector o estantería se encuentra, para ello, se creará una segunda clase
        que se encargará de administrar la ubicación de los libros.
        */
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}
