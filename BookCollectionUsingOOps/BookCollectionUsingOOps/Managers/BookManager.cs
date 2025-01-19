using BookCollectionUsingOOps.Data;
using BookCollectionUsingOOps.Models;
using BookCollectionUsingOOps.Utilities;

namespace BookCollectionUsingOOps.Managers
{
    public class BookManager
    {
        private readonly BookRepository _repository;

        public BookManager()
        {
            _repository = new BookRepository();
        }
        public void ShowMenu()
        {
            Console.WriteLine("1. Add Book to the Collection ");
            Console.WriteLine("2. Update a book in the collection");
            Console.WriteLine("3. Delete a Book in the collection ");
            Console.WriteLine("4. Get all the books from the collection");      
            Console.WriteLine("5. Exit");
            Console.WriteLine();
        }

        public void CreateBook()
        {
            Book book = new Book();

            int id = AutoIncrement.GenerateId();
            book.Id = id;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the year book is published: ");
            Console.ResetColor();
            int year = Convert.ToInt32(Console.ReadLine());
            book.Year = year;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the author of the book: ");
            Console.ResetColor();
            string author = Console.ReadLine();
            book.Author = author;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the title of the book: ");
            Console.ResetColor();
            string title = Console.ReadLine();
            book.Title = title;

            _repository.CreateBook(book);
            Console.WriteLine($"Book added successfully to the collection: {book.Title}");
            Console.WriteLine();
        }

        public void UpdateBook()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the ID of the book to be updated: ");
            Console.ResetColor();
            int idToUpdate = Convert.ToInt32(Console.ReadLine());
            Book updatedBook = new Book();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the new year: ");
            Console.ResetColor();
            int updatedYear = Convert.ToInt32(Console.ReadLine());
            updatedBook.Year = updatedYear;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the new Author: ");
            Console.ResetColor();
            string newAuthor = Console.ReadLine();
            updatedBook.Author = newAuthor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the new Title: ");
            Console.ResetColor();

            string newTitle = Console.ReadLine();
            updatedBook.Title = newTitle;

            if(_repository.UpdateBook(idToUpdate, updatedBook)==false)
                Console.WriteLine("Book cannot be updated!! There is an error in input");
            else
            {
                _repository.UpdateBook(idToUpdate, updatedBook);
                Console.WriteLine("The book has been updated successfully");
            }
            Console.WriteLine();
            
        }

        public void ViewBooks()
        {
            List<Book> books = _repository.ViewBooks();

            // Print header
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"{"ID",-5} {"Title",-30} {"Author",-20} {"Year",-5}");
            Console.WriteLine("----------------------------------------------------------");

            // Print book details
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Id,-5} {book.Title,-30} {book.Author,-20} {book.Year,-5}");
            }

            Console.WriteLine("----------------------------------------------------------");

        }

        public void DeleteBook()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            if (_repository.DeleteBook(id) == false)
                Console.WriteLine("Book can't be deleted");
            else
            {
                _repository.DeleteBook(id);
                Console.WriteLine("Book deleted succesfully!!");
            }
            Console.WriteLine();
        }
    }
}
