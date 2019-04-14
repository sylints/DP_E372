using System;

namespace E372
{
    class Program
    {
        // Given a string containing only the characters x and y, find whether there are the same number of xs and ys.
        static void Main(string[] args)
        {
            int xs = 0;
            int ys = 0;

            Console.WriteLine("Enter your string of X's and Y's and see if perfectly balanced");
            char[] userInput = Console.ReadLine().ToCharArray();

            foreach (char c in userInput)
            {
                if (c == 'x')
                {
                    xs++;
                }
                else if (c == 'y')
                {
                    ys++;
                }
            }

            if (xs == ys)
            {
                Console.WriteLine("Perfectly balanced.");
            }
            else
            {
                Console.WriteLine("Not balanced");
            }

        }
    }
}
