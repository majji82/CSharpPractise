using BookCollectionUsingOOps.Managers;

namespace BookCollectionUsingOOps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();

            bool exit = false;

            while(!exit)
            {
                Console.WriteLine("Welcome to Book Collection Manager!");
                manager.ShowMenu();
                Console.WriteLine("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        manager.CreateBook();
                        break;
                    case 2:
                        manager.UpdateBook();
                        break;
                    case 3:
                        manager.DeleteBook();
                        break;
                    case 4:
                        manager.ViewBooks();
                        break;
                    case 5:
                        Console.WriteLine("Thanks for using our Book Manager!!");
                        exit = true;
                        break;
                }
            }
        }
    }
}
