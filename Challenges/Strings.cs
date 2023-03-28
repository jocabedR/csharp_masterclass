using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Numerics;
using System.Xml.Linq;

namespace Hello_world
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name and press enter: ");
            string name = Console.ReadLine();
            string sub = String.Format(name.Substring(1,2));

            Console.WriteLine("Uppper case: |{0}|", name.ToUpper());
            Console.WriteLine("Lower case: |{0}|", name.ToLower());
            Console.WriteLine("Without finitial and final spaces: |{0}|", name.Trim());
            Console.WriteLine("Substring: {0}", sub);
        }
    }
}