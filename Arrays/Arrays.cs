using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //Store collection of variables of same type
            //int[] numbers = new int[2]; //need to specify size on initialization
            var numbers = new int[2];
            numbers[0] = 1; // 0 indexed
            numbers[1] = 5;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine("");

            int[] numbersNew = new int[4] {1, 4, 3, 2};
            for (int i = 0; i < numbersNew.Length; i++)
            {
                Console.Write(numbersNew[i]);
            }
            Console.WriteLine("");

            var names = new string[3] {"James", "Molly", "Jane"};
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names);
            }
            
        }
    }
}
