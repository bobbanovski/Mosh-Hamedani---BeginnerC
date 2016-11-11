using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomisation
{
    class Randomisation
    {
        static void Main(string[] args)
        {
            //Create instance of random class
            var random = new Random();
            for (var i = 0; i < 10; i++)
                //Print random number between 1 and 10
                Console.WriteLine(random.Next(1, 10));
            
            //Random characters
            Console.WriteLine((int)'a'); //converts 'a' to ASCII number

            const int passwordLength = 10;
            char[] buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char) ('a' + random.Next(0, 26));
                Console.Write(buffer[i]);
            }
            Console.Write("\n");

            var password = new string(buffer); //pass buffer char array
            Console.WriteLine(password);
        }
    }
}
