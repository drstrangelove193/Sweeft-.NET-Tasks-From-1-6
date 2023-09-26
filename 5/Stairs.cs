using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft
{
    internal class Stairs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CountVariants(5));
        }
        /* lets simplify the problem to count the variants and see the recurring pattern, if n = 1(we have a staircase with only 1 stairs)
         * In that case the number of variants will be only 1. so when stairCount == 1, variants = 1. if n = 2 (we have a staircase with 2 stairs)
         * Now we have 2 variants to go up to 2 stairs, first will be taking one step at a time and second - jumping 2 stairs at a time. Now 
         * if we have 3 stairs now we can go 1. one stair at a time 2. take one stair at first and then jump 2 stairs 3. jump 2 stairs at first and
         * then take one step- in total 3 variants. if n = 4 we can 
         * 1. take one stair at a time : 0-1 1-2 2-3 3-4
         * 2. take 2 jumps from 0-2, 2-4
         * 3. take one stair, then again one and jump 0-1 1-2 2-4
         * 4. take one stair, jump, take one stair 0-1 1-3 3-4
         * 5. jump once and then take one stair at a time 0-2 2-3 3-4
         * so when stairCount = 4 we have 5 variants. we can notice that there is a pattern when
         *  n = 1, variants = 1,
         *  n = 2, variants = 2,
         *  n = 3, variants = 3,
         *  n = 4, variants = 5,
         *  
         *  if we continue we can see that  variants(n) = variants(n-1) + variants(n-2) we can write this function recursively
         */
        static int CountVariants(int stairCount)
        {
            //Check for the base case
            if (stairCount == 1) return 1;
            if (stairCount == 2) return 2;

            return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);
        }
    }
}
