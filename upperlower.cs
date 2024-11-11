using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    class Program
    {
        static void Main()
        {
            // Read the first string (expected to be in uppercase)
            Console.WriteLine("Enter a string in uppercase: ");
            string upperString = Console.ReadLine();

            // Read the second string (expected to be in lowercase)
            Console.WriteLine("Enter a string in lowercase: ");
            string lowerString = Console.ReadLine();

            // Convert the uppercase string to lowercase
            string convertedUpperToLower = upperString.ToLower();

            // Convert the lowercase string to uppercase
            string convertedLowerToUpper = lowerString.ToUpper();

            // Output the converted strings
            Console.WriteLine($"Converted uppercase to lowercase: {convertedUpperToLower}");
            Console.WriteLine($"Converted lowercase to uppercase: {convertedLowerToUpper}");


            Console.ReadKey();
        }
    }
}