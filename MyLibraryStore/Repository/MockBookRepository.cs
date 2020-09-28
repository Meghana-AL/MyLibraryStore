using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLibraryStore.Models;
using System.Security.Cryptography.X509Certificates;

namespace MyLibraryStore.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public void AddBook(BookDetails book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int Id)
        {
            throw new NotImplementedException();
        }

        public BookDetails GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable<BookDetails> GetBooks()
        {
            return new List<BookDetails>
            {
                new BookDetails{Id=1, BookName="Wings Of Fire",Author="APJ Abdul Kalam",ISBN="IS12345",PublishDate=Convert.ToDateTime("10/05/2012")},
                new BookDetails{Id=2, BookName="Harry Potter",Author="JK Rowling ",ISBN="IS87645",PublishDate=Convert.ToDateTime("30/04/2003")},
                new BookDetails{Id=3, BookName="Mahaswetha",Author="Sudha Murthy",ISBN="IS18794",PublishDate=Convert.ToDateTime("16/10/2015")},
                new BookDetails{Id=4, BookName="Wolf Hall",Author="Hilary Mantel",ISBN="IS12376",PublishDate=Convert.ToDateTime("10/04/2012")},
                new BookDetails{Id=5, BookName="Outline",Author="Rachel Cusk",ISBN="IS18745",PublishDate=Convert.ToDateTime("20/07/2012")},
            };
        }

        public void UpdateBook(int? Id, BookDetails book)
        {
            throw new NotImplementedException();
        }
    }
}
