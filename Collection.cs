using System.Collections.Generic;

namespace BookCollection
{
    public class Collection
    {
        private List<Book> _books = new List<Book>();
        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public Book GetBook(int index)
        {
            return _books[index];
        }

        public void RemoveBook(int index)
        {
             _books.RemoveAt(index);
        }
        public void PrintAllBooks()
        {
            for (int i = 0; i < _books.Count; i++)
            {
                System.Console.WriteLine("................");
                System.Console.WriteLine("Title: {0}", _books[i].Title);
                System.Console.WriteLine("Author: {0}", _books[i].Author);
                System.Console.WriteLine("Year release: {0}", _books[i].YearReleased);
                System.Console.WriteLine("{0:c}", _books[i].Price);
                System.Console.WriteLine("................"); 
            }
        }
    }
}