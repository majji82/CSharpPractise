using BookCollectionUsingOOps.Models;

namespace BookCollectionUsingOOps.Data
{
    public interface IBookRepository
    {
        void CreateBook(Book book);
        List<Book> ViewBooks();
        bool UpdateBook(int id, Book updatedBook);
        bool DeleteBook(int id);
    }
}
