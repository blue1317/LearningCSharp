using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ArrayAndListExercises
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
            var friends = new List<string>();
            Console.WriteLine("Please enter your Friend's Name (or press enter if you are done/dont have any to enter).");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "")
                    break;

                friends.Add(input);
            }

            switch (friends.Count)
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post.", friends[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} likes your post.", friends[0], friends[1]);
                    break;
                case 3:
                    Console.WriteLine("{0} and {1} and {2} other likes your post.", friends[0], friends[1], friends.Count - 2);
                    break;
                default:
                    Console.WriteLine("{0} and {1} and {2} others likes your post.", friends[0], friends[1], friends.Count - 2);
                    break;
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter a Name you want reversed.");
            var input = Console.ReadLine();
            char[] name;
            name = input.ToCharArray(0, input.Length);
            Array.Reverse(name);
            var reversedName = "";
            foreach (var chr in name)
            {
                reversedName += chr;
            }

            Console.Write("The name reversed is: " + reversedName);

        }

        public static void Exercise3()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.Write("Enter a Number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.Write("Please enter an unique number: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(input);
                }
                else
                {
                    numbers.Add(input);
                }
            }
            numbers.Sort();
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Exercise4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type Quit to exit.");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var noDupe = new List<int>();
            noDupe = numbers.Distinct().ToList();

            foreach (var n in noDupe)
            {
                Console.WriteLine(n);
            }
        }

        public static void Exercise5()
        {
            string[] strNumbers;

            while (true)
            {
                Console.Write("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10): ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    strNumbers = input.Split(',');
                    if (strNumbers.Length == 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var num in strNumbers)
            {
                numbers.Add(Convert.ToInt32(num));
            }

            numbers.Sort();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
