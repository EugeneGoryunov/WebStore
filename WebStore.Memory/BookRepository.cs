using System;
using System.Linq;

namespace WebStore.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 5555567891234", "Piter", "GoF"),
            new Book(2, "ISBN 2222267891234", "Bob", "Совершенный код"),
            new Book(3, "ISBN 1234567891234", "Mark", "Чистый код")

        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitle(string query)
        {
            return books.Where(book => book.Author == query || book.Title == query).ToArray();
        }
    }
}
