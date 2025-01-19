using BookCollectionUsingOOps.Models;
namespace BookCollectionUsingOOps.Data
{
    public class BookRepository : IBookRepository
    {
        private static List<Book> books = new List<Book>();
        public void CreateBook(Book book)
        {
            books.Add(book);
        }

        public bool DeleteBook(int id)
        {
            return books.RemoveAll(b =>  b.Id == id) > 0;
        }

        public List<Book> ViewBooks()
        {
            return books;
        }

        public bool UpdateBook(int id, Book updatedBook)
        {
            var book = books.Find(b => b.Id == id);
            if (book == null) return false;
            else
            {
                book.Title = updatedBook.Title;
                book.Author = updatedBook.Author;
                book.Year = updatedBook.Year;
                return true;
            }
        }
    }
}
