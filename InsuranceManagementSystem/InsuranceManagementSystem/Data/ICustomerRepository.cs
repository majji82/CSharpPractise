using InsuranceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Data
{
    public interface ICustomerRepository
    {
        void AddPolicy(InsurancePolicy policy);
        void RemovePolicy(int policyNumber);
        void displayCustomerDetails();
    }
}
