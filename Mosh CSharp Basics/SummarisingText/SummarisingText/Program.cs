using System;
using System.Collections.Generic;

namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsumLorem ipsumv Lorem ipsumLorem ipsum Lorem ipsum Lorem ipsumvv vvvLorem ipsumLorem ipsum Lorem ipsum Lorem ipsum";
            var summary = StringUtil.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }

    }
}
