using System;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Numerics;
using System.Xml.Linq;
using System.Data.SqlTypes;
using static System.Net.Mime.MediaTypeNames;

namespace Hello_world
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" S I G N    I N");
            Console.WriteLine("Enter a username: ");
            string username= Console.ReadLine();
            Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine();

            Console.WriteLine("\n\n L O G    I N");
            Console.WriteLine("Enter your username: ");
            string logUsername = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string logPassword = Console.ReadLine();

            if (username == logUsername && password == logPassword)
            {
                Console.WriteLine($"{username} is registred.");
            }
            else {
                Console.WriteLine($"User not founded.");
            }
        }
    }
}