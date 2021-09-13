using System;
using System.Collections.Generic;
using System.Text;

namespace SummarisingText
{
    public class StringUtil
    {
        public static string SummerizeText(string sentence, int maxLength = 20)
        {

            if (sentence.Length < maxLength)
            {
                return sentence;
            }
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += words.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                return string.Join(" ", summaryWords) + "...";
            }
        }

    }
}
