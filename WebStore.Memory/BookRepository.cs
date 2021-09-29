using System;
using System.Collections.Generic;
using System.Linq;

namespace WebStore.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 5555567891234", "Роберт Мартин", "Чистая архитектура", "Искусство разработки ПО", 865),
            new Book(2, "ISBN 2222267891234", "Стив Макконели", "Совершенный код", "Практическое руководство по разработке ПО", 1260),
            new Book(3, "ISBN 1234567891234", "Роберт Мартин", "Чистый код", "Создание, анализ и рефакторинг", 696)

        };

        public Book[] GetAllByIds(IEnumerable<int> bookIds)
        {
            var foundBooks = from book in books
                             join bookId in bookIds on book.Id equals bookId
                             select book;

            return foundBooks.ToArray();
        }

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
