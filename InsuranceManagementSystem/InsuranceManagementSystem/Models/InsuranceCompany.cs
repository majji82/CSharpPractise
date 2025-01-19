using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Models
{
    public class InsuranceCompany
    {
        private List<Customer> _customerList;

        public List<Customer> CustomerList
        {
            set { _customerList = value; }
            get { return _customerList; }
        }
    }
}
