﻿using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ; }
        //public Shelves Shelve {get ; set ;}
        public string LibrarySector {get; set;}
        public string LibraryShelve {get; set;}

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

    }
}
