using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace ControlFlow_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // START Condition Exercise 1
            Console.WriteLine("Please enter a number between 1 and 10.");
            var input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid Input");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            // END Condition Exercise 1

            Console.WriteLine();

            // START Condition Exercise 2
            Console.WriteLine("Please enter a number.");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            var number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(number1 > number2 ? number1 + " is the larger number." : number2 + " is the larger number.");
            // END Condition Exercise 2

            Console.WriteLine();

            // START Condition Exercise 3
            Console.WriteLine("Please enter the image height.");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the image width.");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (height > width)
            {
                Console.WriteLine("The image has Portrait orientation");
            }
            else if (width > height)
            {
                Console.WriteLine("The image has Landscape orientation");
            }
            else
            {
                Console.WriteLine("The image has Square orientation");
            }
            // END Condition Exercise 3

            Console.WriteLine();

            // START Condition Exercise 4
            Console.WriteLine("What is the speed limit?");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the speed of the car?");
            var speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (speed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                GetPoints(speed, speedLimit);
            }
            // END Condition Exercise 4

        }

        public static void GetPoints(int num1, int num2)
        {
            int speedDiff = num1 - num2;
            int demeritPoints = speedDiff / 5;

            if (demeritPoints > 12)
            {
                Console.WriteLine("License Suspended");
            }
            else
            {
                Console.WriteLine(demeritPoints);
            }
        }
    }
}
