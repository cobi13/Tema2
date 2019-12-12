using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Radu";
            string SecondName = "Cobiliac";

            //Concatenating

            string fullName = firstName + " " + SecondName;

            //Searching

            int index = fullName.IndexOf("Cobi");

            //Extracting Substrings

            string extract = fullName.Substring(5, 2);

            //Replacing

            string replace = fullName.Replace(" ", "          ");

            //Remove

            string remove = fullName.Remove(5, 8);

            //ToLower

            string lower = fullName.ToLower();

            //ToUpper

            string upper = fullName.ToUpper();


            Console.WriteLine(fullName);
            Console.WriteLine(index);
            Console.WriteLine(extract);
            Console.WriteLine(replace);
            Console.WriteLine(remove);
            Console.WriteLine(lower);
            Console.WriteLine(upper);
            Console.ReadKey();
        }
    }
}
