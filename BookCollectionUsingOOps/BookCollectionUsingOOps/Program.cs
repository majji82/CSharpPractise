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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome to Book Collection Manager!");
                Console.ResetColor();

                manager.ShowMenu();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Select your choice: ");
                Console.ResetColor();
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
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
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Thanks for using our Book Manager!!");
                        Console.ResetColor();
                        exit = true;
                        break;
                }
            }
        }
    }
}
