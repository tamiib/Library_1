using Library_2.DAL;
using Library_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_2.Repozitory
{
    public class AuthorRepozitory
    {
        private DatabaseContext _databaseContext;
        public AuthorRepozitory(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public List<Author> GetAuthors()
        {
            var Authors = new List<Author>();
            Authors = _databaseContext.Authors.ToList();
            return Authors;
        }
        public void AddAuthors(Author Author)
        {
            _databaseContext.Authors.Add(Author);
            _databaseContext.SaveChanges();
        }
        public void DeleteAuthors(Author author)
        {
                _databaseContext.Authors.Remove(author);
                _databaseContext.SaveChanges();
            
        }
        public void UpadteAuthors(Author updateAuthor)
        {
            var temp = _databaseContext.Authors.FirstOrDefault(item => item.Id == updateAuthor.Id);
            if (temp != null)
            {
                temp.FirstName = updateAuthor.FirstName;
                temp.LastName = updateAuthor.LastName;
                temp.Id = updateAuthor.Id;
                temp.Books = updateAuthor.Books;
                _databaseContext.SaveChanges();
            }
        }
    }
}
