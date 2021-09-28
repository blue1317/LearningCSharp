using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ControlFlow_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.Exercise1();
            //Program.Exercise2();
            //Program.Exercise3();
            //Program.Exercise4();
            //Program.Exercise5();
        }

        public static void Exercise1()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine(count);
        }

        public static void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a Number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input != "ok")
                {
                    var num = Convert.ToInt32(input);
                    sum += num;
                    Console.WriteLine(sum);
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter a Number.");
            var num = Convert.ToInt32(Console.ReadLine());
            var sum = 1;
            for (var i = num; i > 0; i--)
            {
                sum *= i;
            }
            Console.WriteLine("{0}! = {1}", num, sum);
        }

        public static void Exercise4()
        {
            var secretNum = new Random().Next(1, 10);
            var attempts = 4;
            //Debug only
            //Console.WriteLine("The secret number is: " + secretNum);
            //Console.WriteLine();
            do
            {
                Console.WriteLine("Guess a Number between 1 and 10");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == secretNum)
                {
                    Console.WriteLine("You Won");
                    return;
                }
                else
                {
                    attempts--;
                    Console.WriteLine("You Lost, Please try again, you have " + attempts + " chances left!");
                    Console.WriteLine();
                    
                }
            } while (attempts > 0);

            if (attempts == 0)
                Console.WriteLine("The secret number was: " + secretNum);

        }

        public static void Exercise5()
        {
            // More advance way of working through this example.

            //Console.WriteLine("Enter a series of numbers separated by comma");
            //var input = Console.ReadLine();

            //var strNumbers = input.Split(',');

            //var number = new int[input.Length];
            //for (int i = 0; i <= strNumbers.Length-1; i++)
            //{
            //    number[i] = int.Parse(strNumbers[i]);
            //}

            //Console.WriteLine(number.Max());

            // Beginner way of working through this example.

            //Console.Write("Enter commoa separated numbers: ");
            //var input = Console.ReadLine();

            //var numbers = input.Split(',');

            //// Assume the first number is the max 
            //var max = Convert.ToInt32(numbers[0]);

            //foreach (var str in numbers)
            //{
            //    var number = Convert.ToInt32(str);
            //    if (number > max)
            //        max = number;
            //}

            //Console.WriteLine("Max is " + max);
        }
    }
}
