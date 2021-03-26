using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.model.REpositry
{
    public class AuthorRepositry : IBookStoreRepo<Author>
    {
        List<Author> authors;
        public AuthorRepositry()
        {
            authors = new List<Author>()
            {
               new Author {Id = 1 , fullName="Abdelrahman" },
               new Author {Id = 2 , fullName="Abdelrahman2" },
               new Author {Id = 3 , fullName="Abdelrahman3" },
                              
            };
            
        }
        public IList<Author> List()
        {
            return authors;
        }

        public Author find(int id)
        {
            return authors.SingleOrDefault(x => x.Id == id);
        }

        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void update(int id, Author entity)
        {
            var author = find(id);
            author.fullName = entity.fullName;
        }

        public void Delete(int id)
        {
            var author = find(id);
            authors.Remove(author);
        }
    }
}