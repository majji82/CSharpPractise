using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollectionUsingOOps.Utilities
{
    public static class AutoIncrement
    {
        private static int _id = 1;
        public static int GenerateId()
        {
            return _id++;
        }
    }
}
