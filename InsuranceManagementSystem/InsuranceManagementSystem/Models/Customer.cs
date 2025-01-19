using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Models
{
    public class Customer
    {
        private int _customerId;

        private string _name;

        private string _address;

        private string _email;

        private string _phone;

        private List<InsurancePolicy> _policies;

        public Customer()
        {
            _policies = new List<InsurancePolicy>();
        }

        public int CustomerId
        {
            set { _customerId = value; }
            get { return _customerId; }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }

        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }

        public List<InsurancePolicy> Policies
        {
            set { _policies = value; }
            get { return _policies; }
        }
    }
}
