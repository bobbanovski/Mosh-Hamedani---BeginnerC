using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Iteration
    {
        static void Main(string[] args)
        {
            //For loop
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i);
            }
            Console.WriteLine("\n");
            for (var i = 10; i >= 1; i--)
                if(i % 2 == 0)
                    Console.Write(i);
            Console.WriteLine("\n");
            //Foreach loop
            var name = "John Smith";
            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            foreach (var character in name)
            {
                Console.Write(character);
            }
            Console.WriteLine("\n");
            var numbers = new int[] {1, 2, 3, 4};
            foreach (var num in numbers)
            {
                Console.Write(num);
            }
            Console.WriteLine("\n");
            //While loop - good if number of times required for iteration
            // not known
            var j = 0;
            while (j <= 10)
            {
                if(j%2 == 0)
                    Console.WriteLine(j);
                j++;
            }

            while (true)
            {
                Console.WriteLine("Please enter your name");
                var input = Console.ReadLine();

                if(!string.IsNullOrWhiteSpace(input))
                    Console.WriteLine("@Echo: " + input);
                    continue;
                break;
            }
            //Do - while loop


        }
    }
}
