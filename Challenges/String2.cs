using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Numerics;
using System.Xml.Linq;
using System.Data.SqlTypes;

namespace Hello_world
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            string stng = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            char character = Console.ReadLine()[0];
            Console.WriteLine(stng.IndexOf(character));

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

           string fullName = string.Concat(firstName, " ",lastName);
            Console.WriteLine(fullName);

        }
    }
}