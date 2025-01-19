using InsuranceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Data
{
    public class PolicyRepository : IPolicyRepository
    {
        List<InsurancePolicy> policies = new List<InsurancePolicy>();
        public void calculatePremium()
        {
            Console.WriteLine(100);
        }

        public void displayPolicyDetails()
        {
            
            if(policies.Count > 0)
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine($"{"Policy Number",-20} {"Policy Type",-15} {"Premium Amount",-15} {"Coverage Amount",-15}");
                Console.WriteLine("---------------------------------------------------------------");


                foreach (var policy in policies)
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
}
