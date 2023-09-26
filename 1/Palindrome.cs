using System;
using static System.Net.Mime.MediaTypeNames;

namespace Sweeft
{
    internal class Palindrome
    {
        public static void Main(string[] args)
        {
            //Getting Input string from user
            String str;
            Console.Write("Enter a String: ");


            //Convert to lower case to make it case insensitive
            str = Console.ReadLine().ToLower();

            if (IsPalindrome(str))
                Console.WriteLine($"{str} is Palindrome");
            else
                Console.WriteLine($"{str} is not a Palindrome");
        }

        /* Recursive function to check if string is palindrome. We start comparing the first and the last character of the string,
        if they are equal we continue comparing using recursion calling method and passing substring. Now we compare the second character
        from the start and the second character from the end and so on we continue. at some point we reach the middle of the string so
        start becomes greater or equal to end(depending on the number of characters of the string) that means we have checked
        all characters and the string is indeed a Palindrome.
        */
        static bool CheckPalindrome(String str, int start, int end)
        {
            if (start >= end)
            {
                return true;
            }
            else if (str[start] == str[end])
            {
                return CheckPalindrome(str, start + 1, end - 1);
            }
            else
            {
                return false;
            }
        }

        // Wrapper function for recursive function
        static bool IsPalindrome(String text)
        {
            int length = text.Length;

            // An empty string and string with only one character is considered as a Palindrome
            if (length == 0 || length == 1) return true; 

            return CheckPalindrome(text, 0, length - 1);
        }
    }
}
