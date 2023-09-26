using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft
{
    internal class Change
    {
        // constans as given the coins
        const int FIFTY = 50;
        const int TWENTY = 20;
        const int TEN = 10;
        const int FIVE = 5;
        const int ONE = 1;

        public static void Main(string[] args)
        {
            //do while loop to avoid negative numbers
            int amount;
            do
            {
                Console.Write("Enter Amount in Cents: ");
                amount = Convert.ToInt32(Console.ReadLine());
            } while (amount < 0);

            Console.WriteLine($"The minimum number of coins to change {amount} TeTri is {MinSplit(amount)}");
        }



        //Wrapper function here we start from fifties and calculate minimum number of coins reqired to change given amount
        static int MinSplit(int amount)
        {
            int fifties = CalculateFifties(amount);
            amount -= fifties * FIFTY;

            int twenties = CalculateTwenties(amount);
            amount -= twenties * TWENTY;

            int tens = CalculateTens(amount);
            amount -= tens * TEN;

            int fives = CalculateFives(amount);
            amount -= fives * FIVE;

            int ones = CalculateOnes(amount);
            amount -= ones * ONE;

            return fifties + twenties + tens + fives + ones;
        }



        //Helper function to calculate how many fifties does amount contain
        static int CalculateFifties(int amount)
        {
            return amount / FIFTY;
        }

        //Helper function to calculate how many twenties does amount contain
        static int CalculateTwenties(int amount)
        {
            return amount / TWENTY;
        }

        //Helper function to calculate how many tens does amount contain
        static int CalculateTens(int amount)
        {
            return amount / TEN;
        }

        //Helper function to calculate how many fives does amount contain
        static int CalculateFives(int amount)
        {
            return amount / FIVE;
        }

        //Helper function to calculate how many ones does amount contain
        static int CalculateOnes(int amount)
        {
            return amount / ONE;
        }
    }
}
