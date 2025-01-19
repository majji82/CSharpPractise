using InsuranceManagementSystem.Data;
using InsuranceManagementSystem.Models;
using InsuranceManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Managers
{
    public class Manager
    {
        private readonly CompanyRepository _companyRepository;
        private readonly CustomerRepository _customerRepository;
        public Manager()
        {
            _companyRepository = new CompanyRepository();  
            _customerRepository = new CustomerRepository(_companyRepository);
        }

        AutoIncrement custIdIncrement = new AutoIncrement();
        AutoIncrement policyIdIncrement = new AutoIncrement();


        public void displayMenu()
        {
            Console.WriteLine("1. Add a new customer ");
            Console.WriteLine("2. Remove a Customer ");
            Console.WriteLine("3. Add a policy to a Customer ");
            Console.WriteLine("4. Remove a policy to a Customer ");
            Console.WriteLine("5. Display Customer's details ");
            Console.WriteLine("6. Display all customers");
            Console.WriteLine("7. Exit");
            Console.WriteLine();
        }

        public void CreateCustomer()
        {
            Customer customer = new Customer();

            int custId = custIdIncrement.IncrementId();
            customer.CustomerId = custId;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the Customer Name: ");
            Console.ResetColor();
            string name = Console.ReadLine();
            customer.Name = name;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter Address: ");
            Console.ResetColor();
            string address = Console.ReadLine();
            customer.Address = address;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the email: ");
            Console.ResetColor();
            string email  = Console.ReadLine();
            Console.ResetColor();
            customer.Email = email;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the Phone: ");
            Console.ResetColor();
            string phone = Console.ReadLine();
            customer.Phone = phone;

            _companyRepository.AddCustomer(customer);
            Console.WriteLine();
        }

        public void RemoveCustomer()
        {
            int idToRemove = Convert.ToInt32(Console.ReadLine());
            _companyRepository.RemoveCustomer(idToRemove);
        }

        public void AddPolicyToCustomer()
        {
            InsurancePolicy policy = new InsurancePolicy();

            int policyId = policyIdIncrement.IncrementId();
            policy.PolicyNumber = policyId;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the policy type: ");
            Console.ResetColor();
            string policyType = Console.ReadLine();
            policy.PolicyType = policyType;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the premium amount: ");
            Console.ResetColor();
            double premiumAmount = Convert.ToDouble(Console.ReadLine());
            policy.PremiumAmount = premiumAmount;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the Coverage Amount: ");
            Console.ResetColor();
            double coverageAmount = Convert.ToDouble(Console.ReadLine());
            policy.CoverageAmount = coverageAmount;

            _customerRepository.AddPolicy(policy);
            Console.WriteLine();
        }

        public void RemovePolicyFromCustomer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the customer id to remove policy from: ");
            Console.ResetColor();
            int cid = Convert.ToInt32(Console.ReadLine());

            _customerRepository.RemovePolicy(cid);
            Console.WriteLine();
        }

        public void DisplayAllCustomers()
        {
            _companyRepository.displayAllCustomers();
            Console.WriteLine();
        }

        public void DisplayCustomerDetails()
        {
            _customerRepository.displayCustomerDetails();
            Console.WriteLine();
        }
    }
}
