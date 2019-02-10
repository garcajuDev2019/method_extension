using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_extension
{
    static class Prime
    {
        public static bool IsPrime(this int num)
        {
            int counter = 2;
            bool prime = true;

            while(prime && (counter != num))
            {
                if (num % counter == 0) { prime = false; }
                counter++;
            }
            return prime;
        }
    }
}
