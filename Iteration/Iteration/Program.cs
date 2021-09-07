using System;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // For Loops
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            // Foreach loop (innumerable object) (Arrays, list, String, collections, dictionaries, etc...)
            var numbers = new int[] {1,2,3,4,5}
            ;
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");

            // While Loops
            var j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("");

            // Do While Loop
            var t = false;
            do
            {
                for (var i = 0; i <= 10; i++)
                {
                    if (i == 10)
                    {
                        t = true;
                    }
                    Console.WriteLine(t);
                }
            } while (!t);

        }
    }
}
