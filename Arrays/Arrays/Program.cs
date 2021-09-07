using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Simple calculator with arrays
            var numbers = new int[2];

            Console.WriteLine("Enter a number");
            string a = Console.ReadLine();
            numbers[0] = Convert.ToInt32(a);
            Console.WriteLine(" ");
            Console.WriteLine("Enter another number");
            string b = Console.ReadLine();
            numbers[1] = Convert.ToInt32(b);

            // Add the numbers in the array
            int x = numbers[0] + numbers[1];
            Console.WriteLine(" ");
            // lets do some math from the array
            Console.WriteLine(x);

        }
    }
}
