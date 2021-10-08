using Library_2.DAL;
using Library_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_2.Repozitory
{
    public class BookRepozitory
    {
        private DatabaseContext _databaseContext;
        public BookRepozitory(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public List<Book> GetBooks()
        {
            var Books = new List<Book>();
            //var Authors = new List<Author>();
           // Authors = _databaseContext.Authors.ToList();
            Books = _databaseContext.Books.ToList();
            return Books;
        }
        public void AddBooks(Book book)
        {
            /*Napravit uvjet za provjeru postoji li vec taj autor */
            _databaseContext.Books.Add(book);
            //_databaseContext.Authors.Add(book.Author);
            _databaseContext.SaveChanges();
        }
        public void DeleteBooks(Book book)
        {
            _databaseContext.Books.Remove(book);
            _databaseContext.SaveChanges();
        }
        public void UpdateBook(Book updatedBook)
        {
            var book = _databaseContext.Books.FirstOrDefault(item => item.Id == updatedBook.Id);
            if(book!= null)
            {
                book.Id = updatedBook.Id;
                book.Name = updatedBook.Name;
                book.Availability = updatedBook.Availability;
                book.AuthorId = updatedBook.AuthorId;

                _databaseContext.SaveChanges();
            }
            
           
         
        }
            
        
    }
}
