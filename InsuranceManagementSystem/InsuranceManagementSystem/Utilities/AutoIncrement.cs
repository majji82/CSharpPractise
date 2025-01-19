using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Utilities
{
    public class AutoIncrement
    {
        private int _id = 1;

        public int IncrementId()
        {
            return _id++;
        }
    }
}
