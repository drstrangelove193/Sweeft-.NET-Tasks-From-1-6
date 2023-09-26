using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft
{
    internal class Symbols
    {
        public static void Main(string[] args)
        {
            string sequence;

            Console.Write("Enter A sequence: ");
            sequence = Console.ReadLine();

            if (IsProperly(sequence))
            {
                Console.WriteLine($"{sequence} is a Proper Sequence");
            } else {
                Console.WriteLine($"{sequence} is not a Proper Sequence");
            }
        }

        /*  Length of a Given sequence of '(' and ')' characters must be even, that means for every open parenthesis there should be a closing one
         *  To check matching parenthesis we use Stack as we utilize LIFO. We know that first character in the sequence should be an open parenthesis
         *  We iterate through the sequence and Push open parenthesis in the Stack, when we see close parenthesis ')' we pop his pair of open parenthesis 
         *  from the stack. If provided sequence is correct mathematical sequence of parenthesis we should have pairs of "(" ")" parenthesis and in
         *  the end the stack should be empty.
         * 
         * 
         */
        static bool IsProperly(string sequence)
        {
            //We initialize a stack of characters
            Stack<char> characterStack = new Stack<char>();

            //iterate through the sequence and push open parenthesis
            foreach (char ch in sequence)  
            {
                if (ch == '(')
                {
                    characterStack.Push(ch);
                }
                // When we see close parenthesis we should check if we are at the top of the stack or if we have matching open parenthesis
                else if (ch == ')')
                {
                    if (characterStack.Count == 0 || characterStack.Pop() != '(') return false;
                }
            }

            // In the end , if the stack is empty that means we paired all ( ) parenthesis.
            return characterStack.Count == 0;
        }
    }
}
