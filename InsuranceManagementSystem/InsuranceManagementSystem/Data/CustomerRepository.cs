using InsuranceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CompanyRepository _companyRepository;

        public CustomerRepository(CompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public void AddPolicy(InsurancePolicy policy)
        {
            Console.WriteLine("Enter the customer id to which the policy to be added: ");
            int cid = Convert.ToInt32(Console.ReadLine());


            var cust = _companyRepository.GetCustomerByid(cid);

            if (cust != null)
            {
                cust.Policies.Add(policy);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Policy successfully added to the customer!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Policy cannot be added to that particular Customer!!");
                Console.ResetColor();
            }
        }

        public void displayCustomerDetails()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the id of the customer whose details need to be displayed: ");
            Console.ResetColor();
            int cid = Convert.ToInt32(Console.ReadLine());
            var customer = _companyRepository.GetCustomerByid(cid);
            if (customer != null) 
            {
                Console.WriteLine($"Customer Id       : {customer.CustomerId}");
                Console.WriteLine($"Customer Name     : {customer.Name}");
                Console.WriteLine($"Customer Address  : {customer.Address}");
                Console.WriteLine($"Email             : {customer.Email}");
                Console.WriteLine($"Phone Number      : {customer.Phone}");
                Console.WriteLine();

                if(customer.Policies.Count > 0)
                {
                    Console.WriteLine("Policies:");
                    foreach (var policy in customer.Policies)
                    {
                        Console.WriteLine($"  - Policy Number  : {policy.PolicyNumber}");
                        Console.WriteLine($"    Policy Type    : {policy.PolicyType}");
                        Console.WriteLine($"    Premium Amount : {policy.PremiumAmount}");
                        Console.WriteLine($"    Coverage Amount: {policy.CoverageAmount}");
                        Console.WriteLine(); // Blank line between policies
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There are no policies to be displayed!!");
                    Console.ResetColor();
                }

            }
            Console.WriteLine();
        }

        public void RemovePolicy(int policyNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the Customer Id for whom the policy is to be removed: ");
            Console.ResetColor();
            int cid = Convert.ToInt32(Console.ReadLine());

            var cust = _companyRepository.GetAllCustomers().Find(customer => customer.CustomerId == cid);
            if (cust != null)
            {
                if (cust.Policies.Count > 0)
                {
                    var policy = cust.Policies.Find(policy => policy.PolicyNumber == policyNumber);
                    cust.Policies.Remove(policy);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There are no policies to be displayed!!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Policies cannot be removed");
                Console.ResetColor();
                
            }

            Console.WriteLine();

        }
    }
}
