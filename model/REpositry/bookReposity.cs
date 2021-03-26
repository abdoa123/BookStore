using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.model.REpositry
{
    public class bookReposity : IBookStoreRepo<Book>
    {
        List<Book> books;
        public bookReposity()
        {
            books = new List<Book>(){
                new Book {
                    Id = 1 , title="C# BOOK" , description= "good book from the author"
                },
                new Book{
                    Id = 2 , title="C++ BOOK " , description="test description"
                }
            };   
        }
        public IList<Book> List()
        {
            return books;
        }

        public Book find(int id)
        {
            return books.SingleOrDefault(x => x.Id == id);
        }

        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void update(int id,Book newBook)
        {
            var book = find(id);
            book.author = newBook.author;
            book.description = newBook.description;
            book.title = newBook.title;

        }

        public void Delete(int id)
        {
            var book = find(id);
            books.Remove(book);

        }
    }
}