/**
* 10/5/2022
* CSC 253
* Ramon Muniz Crespo
* Prime Number Generation
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number_Generation
{
    class PrimeNumber
    {
        private static bool IsPrime(int number)
        {
            if ((number & 1) == 0)
            {
                return (number == 2);
            }

            int limit = (int)Math.Sqrt(number);

            for (int i = 3; i <= limit; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}