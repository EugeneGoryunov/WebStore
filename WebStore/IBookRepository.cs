using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore
{
    public interface IBookRepository
    {
        Book[] GetAllByIsbn(string isbnPart);
        Book[] GetAllByTitle(string titleOrAuthorPart);
        Book GetById(int id);
    }
}
