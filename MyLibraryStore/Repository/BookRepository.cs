using Microsoft.EntityFrameworkCore;
using MyLibraryStore.Data;
using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext _dbContext = null;

        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBook(BookDetails book)
        {
            var books = _dbContext.Books.ToList();
            if(book==null)
            {
                throw new ArgumentException(nameof(book));
            }
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int Id)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == Id);
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

        public BookDetails GetBookById(int id)
        {
            return _dbContext.Books.ToList().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<BookDetails> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public void UpdateBook(int? Id, BookDetails book)
        {
            if(book==null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            if(Id==null)
            {
                throw new NullReferenceException(nameof(Id));
            }
            var books = _dbContext.Books.SingleOrDefault(book => book.Id == Id.Value);
            books.BookName = book.BookName;
            books.Author = book.Author;
            books.PublishDate = book.PublishDate;
            books.ISBN = book.ISBN;
            books.Genre = book.Genre;
            _dbContext.SaveChanges();
        }
    }
}
