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
            string friend1 = "Esther";
            string friend2 = "Vicky";
            string friend3 = "Pato";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

        }

        public static void GreetFriend(string friend){
            Console.WriteLine($"Hi {friend}, my friend!");
        }
    }
}