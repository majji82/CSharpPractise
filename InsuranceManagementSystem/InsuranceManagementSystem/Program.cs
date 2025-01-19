using InsuranceManagementSystem.Managers;

namespace InsuranceManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();


            bool exit = false;

            while(!exit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome to Insurance Application!!");
                Console.ResetColor();
                manager.displayMenu();
                Console.WriteLine("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch(choice)
                {
                    case 1:
                        manager.CreateCustomer();
                        break;
                    case 2:
                        manager.RemoveCustomer();
                        break;
                    case 3:
                        manager.AddPolicyToCustomer();
                        break;
                    case 4:
                        manager.RemovePolicyFromCustomer();
                        break;
                    case 5:
                        manager.DisplayCustomerDetails();
                        break;
                    case 6:
                        manager.DisplayAllCustomers();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Thanks for using Policy Manager");
                        Console.ResetColor();
                        exit = true;
                        break;
                }
            }
        }
    }
}
