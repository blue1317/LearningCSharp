using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.demoArray();
            Program.demoList();
        }

        private static void demoList()
        {
            var numList = new List<int>() { 1, 2, 3, 4 };
            numList.Add(1);
            numList.Add(5);
            numList.AddRange(new int[3] { 6, 7, 8});
            foreach (var x in numList)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numList.IndexOf(1));
            Console.WriteLine("Index of 1: " + numList.LastIndexOf(1));

            Console.WriteLine("Count: " + numList.Count);

            numList.Remove(1);
            for (var i = 0; i < numList.Count; i++)
            {
                if (numList[i] == 1)
                    numList.Remove(numList[i]);
            }

            foreach (var x in numList)
                Console.WriteLine(x);

            numList.Clear();
            Console.WriteLine("Count: " + numList.Count);

        }

        public static void demoArray()
        {
            var numbers = new int[] { 3, 9, 5, 7, 17, 10, 13};

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 4);
            Console.WriteLine("Index of 4: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear():");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()
            var copy = new int[3];
            Array.Copy(numbers, copy, 3);

            Console.WriteLine("Effect of Copy():");
            foreach (var i in copy)
            {
                Console.WriteLine(i);
            }

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort():");
            foreach (var j in numbers)
            {
                Console.WriteLine(j);
            }

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse():");
            foreach (var a in numbers)
            {
                Console.WriteLine(a);
            }
        }
    }
}
