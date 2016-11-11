using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    public class StringUtility
    {
        public static string SummarizeText(string sentence, int maxLength = 20)
        {
            //const int maxLength = 20;
            if (sentence.Length < maxLength)
                return sentence;

            //Count words 
            var words = sentence.Split(' ');
            var totalChar = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word); //add word to new list

                totalChar += word.Length + 1; //including space
                if (totalChar > maxLength)
                    break;
            }

            var summary = String.Join(" ", summaryWords) + "...";
            return summary;

        }
    }
}
