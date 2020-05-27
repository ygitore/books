using System;
using System.Collections.Generic;

namespace BookCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book(){
                Title = "Born a Crime",
                Author = "Trevor Noah",
                YearReleased = "2013",
                Price = 20.00
            };
            Book book2 = new Book(){
                Title = "Children of dune",
                Author = "Frank Herbert",
                YearReleased = "1976",
                Price = 30.00
            };
            Book book3 = new Book(){
                Title = "The Diary of a Young Girl",
                Author = "Ana Frank",
                YearReleased = "2008",
                Price = 40.00
            };
            Collection collection = new Collection();
            collection.AddBook(book1);
            collection.AddBook(book2);
            collection.AddBook(book3);
            collection.GetBook(1);
            collection.RemoveBook(1);
            collection.PrintAllBooks();
        }
    }
}
