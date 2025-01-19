using InsuranceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Data
{
    public interface ICompanyRepository
    {
        void AddCustomer(Customer customer);

        void RemoveCustomer(int  customerId);

        void displayAllCustomers();
    }
}
