using lumiBookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace lumiBookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(book => book.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().FindAll(book=> book.Title.Contains(title) || book.Author.Contains(authorName));
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1,Title = "MVC", Author = "Olumide" },
                new BookModel() { Id = 1,Title = "C#", Author = "John" },
                new BookModel() { Id = 1,Title = "Java", Author = "Sarah" },
                new BookModel() { Id = 1,Title = "Php", Author = "Fish" },
                new BookModel() { Id = 1,Title = "C++", Author = "Banks" },
                new BookModel() { Id = 1,Title = "JavaScript", Author = "Kola" },
                new BookModel() { Id = 1,Title = "C#", Author = "Sanders" },
                new BookModel() { Id = 1,Title = "Python", Author = "Michael" },
                new BookModel() { Id = 1,Title = "Kotlin", Author = "Bakers" },
                new BookModel() { Id = 1,Title = "C++", Author = "Saka" },
            };

        }
    }
}
