using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Conditionals
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12) {
                Console.WriteLine("It's morning.");
            } else if (hour >= 12 && hour < 18) {
                Console.WriteLine("It's afternoon");
            } else {
                Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;
            //equivalent logic to the above
            float price2 = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine("Price for " + ((isGoldCustomer) ? "Gold" : "Regular")
                + " Customer: " + price2);

            var season = Season.Winter;
            // Switch Case
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It is Autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer beach time");
                    break;

                case Season.Spring:
                case Season.Winter:
                    Console.WriteLine("Either of these will produce the same response");
                    break;

                default:
                    Console.WriteLine("Season not recognised");
                    break;
            }
        }
    }
}
