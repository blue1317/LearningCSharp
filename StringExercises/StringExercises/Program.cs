using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.Exercise1();
            //Program.Exercise2();
            //Program.Exercise3();
            //Program.Exercise4();
            Program.Exercise5();
        }

        public static void Exercise1()
        {
            Console.WriteLine("Enter in some numbers separated by a hyphen:");
            var input = Console.ReadLine();
            var strNumbers = input.Split('-');
            var numList = new List<int>();
            var isConsecutive = true;

            foreach (var nums in strNumbers)
            {
                numList.Add(Convert.ToInt32(nums));
            }

            for (int i = 1; i < numList.Count; i++)
            {
                if (numList[i] != numList[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }

            }

            Console.WriteLine(isConsecutive == false ? "Not Consecutive" : "Consecutive");
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter in some numbers separated by a hyphen or press Enter to quit");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            var isDupe = false;
            foreach (var nums in input.Split('-'))
                numbers.Add(Convert.ToInt32(nums));

            if (numbers.Count != numbers.Distinct().Count())
                isDupe = true;

            if (isDupe)
                Console.WriteLine("Duplicates");
        }

        public static void Exercise3()
        {
            Console.Write("Enter a time in 24-hour Format (i.e 15:00): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var time = new TimeSpan();
            try
            {
                time = TimeSpan.Parse(input);
                Console.WriteLine(time);
                if (time >= TimeSpan.MinValue && time <= TimeSpan.MaxValue)
                    Console.WriteLine("OK");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

        public static void Exercise4()
        {
            Console.Write("Enter a few words separated by a space: ");
            var input = Console.ReadLine();
            var letters = new List<char>();
            var sb = new StringBuilder();

            foreach (var c in input.ToLower())
            {
                letters.Add(c);
                //Console.WriteLine("DEBUG: what is in our list? " + c);
            }

            // Always make first character in list Capital
            letters[0] = char.ToUpper(letters[0]);
            //Console.WriteLine("DEBUG: First character in List " + letters[0]);
            // Locate characters after a space and capitalize
            for (var i = 1; i < letters.Count; i++)
            {
                if (letters[i] == ' ')
                {
                    var index = letters.IndexOf(' ') + 1;
                    letters[index] = char.ToUpper(letters[index]);
                    //Console.WriteLine("DEBUG: Character after space removal: " + letters[index]);
                    letters.RemoveAt(letters.IndexOf(' '));
                }
            }
            // Append to stringBuilder 
            foreach (var c in letters)
            {
                sb.Append(c);
            }

            Console.WriteLine("Your words as a variable in PascalCase: " + sb);
        }

        public static void Exercise5()
        {
            var numbers = new int[4] {2, 2, 13, 1};
            var target = 15;
            TwoSum(numbers, target);
            
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var output = new int[2];
            var j = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] + nums[j] == target)
                {
                    output[0] = Array.IndexOf(nums, nums[i]);
                    output[1] = Array.LastIndexOf(nums, nums[j]);
                }

                j++;
            }

            Console.WriteLine("[{0},{1}]", output[0], output[1]);

            return output;

        }
    }
}
