using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Lists
    {
        static void Main(string[] args)
        {
            //Lists are mutable - dynamic size
            var numbers = new List<int>();
            var numbers2 = new List<int>() {1, 2, 3, 4}; //Initialise and populate
            numbers2.Add(1);
            numbers.AddRange(new int[3] {5, 6, 7});

            foreach (var number in numbers2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Index of 1: " + numbers2.IndexOf(1)); 
            Console.WriteLine("Last index of 1: " + numbers2.LastIndexOf(1));

            Console.WriteLine("Count of numbers: " + numbers2.Count);

            // numbers2.Remove(1); only removes first instance
            //foreach (var number in numbers2)
            //{
            //    if (number == 1)
            //        numbers2.Remove(number); // cannot modify collection in foreach loop
            //}
            for (var i = 0; i < numbers2.Count; i++)
            {
                if (numbers2[i] == 1)
                    numbers2.Remove(numbers2[i]);
            }
            foreach (var number in numbers2)
            {
                Console.WriteLine(number);
            }

            // ----------- Clear all elements in list
            numbers2.Clear();
         }
    }
}
