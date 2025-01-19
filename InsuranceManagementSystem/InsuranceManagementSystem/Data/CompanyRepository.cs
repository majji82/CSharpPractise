using InsuranceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Data
{
    public class CompanyRepository : ICompanyRepository
    {
        private static List<Customer> customers = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void displayAllCustomers()
        {
            foreach (var customer in customers)
            {
                // Print customer details
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine($"Customer Id   : {customer.CustomerId}");
                Console.WriteLine($"Customer Name : {customer.Name}");
                Console.WriteLine($"Address       : {customer.Address}");
                Console.WriteLine($"Email         : {customer.Email}");
                Console.WriteLine($"Phone         : {customer.Phone}");
                Console.WriteLine("---------------------------------------------------------------");

                // Print policies header
               if(customer.Policies.Count > 0)
                {
                    Console.WriteLine("Policies:");
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine($"{"Policy Number",-20} {"Policy Type",-15} {"Premium Amount",-15} {"Coverage Amount",-15}");
                    Console.WriteLine("---------------------------------------------------------------");

                    // Print each policy
                    foreach (var policy in customer.Policies)
                    {
                        Console.WriteLine($"{policy.PolicyNumber,-20} {policy.PolicyType,-15} {policy.PremiumAmount,-15} {policy.CoverageAmount,-15}");
                    }
                    Console.WriteLine("---------------------------------------------------------------");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There are no policies to be displayed!!");
                    Console.ResetColor();
                }

            }
        }

        public void RemoveCustomer(int customerId)
        {
            customers.RemoveAll(c => c.CustomerId == customerId);
        }

        public Customer? GetCustomerByid(int customerId)
        {
            return customers.FirstOrDefault(c => c.CustomerId == customerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }
    }
}
