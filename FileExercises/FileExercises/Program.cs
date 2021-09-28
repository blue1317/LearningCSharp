using System;
using System.Collections.Generic;
using System.IO;

namespace FileExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Chris\Documents\Repos\LearningCSharp\Resources\test.txt";
            var text = File.ReadAllText(path).Split("\n");
            var words = new List<string>();
            var wordLength = 0;
            foreach (var word in text)
            {
                words.Add(word);
            }
            Console.WriteLine("Number of words in file: " + words.Count);

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length - 1 > wordLength)
                {
                    wordLength = words[i].Length - 1;
                    Console.WriteLine("Word: {0}", words[i]);
                    Console.WriteLine("Length: {0}", wordLength);
                }

            }

            for (int i = 0; i < words.Count; i++)
            {
                if (wordLength == words[i].Length)
                {
                    Console.WriteLine(words[i]);
                    //break;
                }
                    
            }
            

            
        }
    }
}
