using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Models
{
    public class InsurancePolicy
    {
        private int _policyNumber;

        private string _policyType;

        private double _premiumAmount;

        private double _coverageAmount;

        public int PolicyNumber
        {
            set { _policyNumber = value; }
            get { return _policyNumber; }
        }

        public string PolicyType
        {
            set { _policyType = value; }
            get { return _policyType; }
        }

        public double PremiumAmount
        {
            set { _premiumAmount = value; }
            get { return _premiumAmount; }
        }

        public double CoverageAmount
        {
            set { _coverageAmount = value; }
            get { return _coverageAmount; }
        }
    }
}
