using Microsoft.EntityFrameworkCore.Migrations.Operations;
using MyLibraryStore.Migrations;
using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public interface IBookRepository
    {
        IEnumerable<BookDetails> GetBooks();
        BookDetails GetBookById(int Id);
        void AddBook(BookDetails book);
        void UpdateBook(int? Id, BookDetails book);
        void DeleteBook(int Id);
    }
}
