using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft
{
    internal class MinNumber
    {
        public static void Main(string[] args)
        {
            int[] array = { -3, -2, -1, 0, 4, 2, 3, 5, 1, 7, 9};
            Console.WriteLine(NotContains(array));
        }

        // Wrapper function for recursive function
        static int NotContains(int[] array)
        {
            int minPositiveInteger = 1;
            return FindMinimalPositiveInteger(array, minPositiveInteger);
        }

        /* Recursive function to find smallest missing positive integer from array. We start from 1, because 1 is the smallest positive integer 
         and for each call check if array does not contain this number, if so we return smallest positive integer and if it contains then we
        call function again but this time we increase number by 1(so it checks 1, 2, 3, 4, 5 ...). At some point array won't contain next 
        smallest positive integer and we return that number.
        */
        static int FindMinimalPositiveInteger(int[] array, int minPositiveInteger)
        {
            if (!array.Contains(minPositiveInteger))
            {
                return minPositiveInteger;
            } else {
                return FindMinimalPositiveInteger(array, ++minPositiveInteger);
            }
        }
    }
}
