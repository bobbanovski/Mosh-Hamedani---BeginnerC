using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderEx
{
    class StringBuilderEx
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 7)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 7); // Chain multiple methods
            Console.WriteLine(builder);
            //builder.Append('-', 7);
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 7);

            // REPLACE
            builder.Replace('-', '+');

            // REMOVE
            builder.Remove(0, 7);

            // INSERT
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First char " + builder[0]);
        }
    }
}
