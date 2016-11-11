using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Strings
    {
        static void Main(string[] args)
        {
            //Strings are character arrays - immutable
            //String from concatenation of existing strings
            string firstName = "Robert";
            string lastName = "Coleman";
            string fullName = firstName + " " + lastName;
            //Console.WriteLine(fullName);

            // String template from placeholders
            //Format is a static method - no need to instantiate object
            string altName = string.Format("      My Name is: {0}, {1}", firstName, lastName);
            // {0} placeholder 0 - 0-indexed
            
            // String from object array
            var numbers = new int[3] {3, 7, 9};
            string list = string.Join(", ", numbers); //Static method of string class
            //Console.WriteLine(list);

            //String elements
            var charName = altName[0];

            //Special Characters
            string specialStr = "He\nlp \t Ive \\ Fal \'llen \" Can";
            Console.WriteLine(specialStr);

            //Verbatim String
            string muhPath = @"C:\Projects\Pron\DntLook";
            string blah = @"hello
see me now";

            //String methods --------------------------------
                //Alteration
            var lowerName = altName.ToLower();
            var upperName = altName.ToUpper();
            var trimmedName = altName.Trim(); // Removes white space at start and end

            var replaceChar = altName.Replace('o', '!');
            var replaceStr = altName.Replace("Robert", "James");

                //Search
            int location = altName.IndexOf('o');
            int indexName = altName.LastIndexOf("Coleman");

                //Substring
            string selectName1 = altName.Substring(8); // gets everything after this
            string selectName2 = altName.Substring(9, 5); // gets 5 char after this
                
                //Split a single string to an array of individual strings
                //Split based on spaces
            string[] splitted = altName.TrimStart().Split(' ');

                //Check for null or whitespace
            bool checkNull = String.IsNullOrEmpty(altName);
            bool checkNulWhite = String.IsNullOrWhiteSpace(altName);

                //Parse String to number
            string s = "193";
            int i = int.Parse(s);
            int j = Convert.ToInt32(s); // if null or empty, returns 0 no fault.
                //Convert number to string
            string a = i.ToString();
            string b = i.ToString("C"); // formats as currency
            string c = i.ToString("C0"); // formats as currency
        }
    }
}
