using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class StringExample
    {
        static void Main(string[] args)
        {
            var maxLength = 30;
            var sentence = "An incredibly long supercalifragalistic blah blah blah";

            //Console.WriteLine(StringUtility.SummarizeText(sentence, maxLength));

            Console.WriteLine("Enter you input");
            var input = Console.ReadLine();

            var strArray = input.Split('-');

            var check = false;

            var numArray = Convert.ToInt32(strArray);
        }

        //To call from main method - declare static
        //static string SummarizeText(string sentence, int maxLength = 20)
        //{
        //    //const int maxLength = 20;
        //    if (sentence.Length < maxLength)
        //        return sentence;
            
        //        //Count words 
        //        var words = sentence.Split(' ');
        //        var totalChar = 0;
        //        var summaryWords = new List<string>();

        //        foreach (var word in words)
        //        {
        //            summaryWords.Add(word); //add word to new list

        //            totalChar += word.Length + 1; //including space
        //            if (totalChar > maxLength)
        //                break;
        //        }

        //        var summary = String.Join(" ", summaryWords) + "...";
        //        return summary;
            
        //}
    }
}

