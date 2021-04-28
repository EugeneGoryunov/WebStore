using System;
using System.Linq;

namespace WebStore.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 5555567891234", "Piter", "GoF", "qqq", 1500),
            new Book(2, "ISBN 2222267891234", "Bob", "Совершенный код", "aaa", 2000),
            new Book(3, "ISBN 1234567891234", "Mark", "Чистый код", "sssq", 3000)

        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitle(string query)
        {
            return books.Where(book => book.Author == query || book.Title == query).ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
