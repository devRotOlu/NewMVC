using lumiBookStore.Models;
using lumiBookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace lumiBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository= null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var books = _bookRepository.GetAllBooks();
            return View(books);
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookname, string authorName)
        {
            return _bookRepository.SearchBook(bookname,authorName);
        }
    }
}
