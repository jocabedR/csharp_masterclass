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
            byte byteType = 255;
            sbyte sbyteType = -128;
            int intType = 2147483647;
            uint uintType = 4294967295;
            short shortType = 32767;
            ushort ushortType = 65535;
            long longType = -9223372036854775808;
            ulong ulongType = 18446744073709551615;
            float floatType = -3.402823e38f;
            double doubleType = -1.79769313486232e307;
            char charType = 'a';
            bool boolType = true;
            decimal decimalType = 123;

            string stringType = "I control text";
            Console.Write("Enter a integer  : ");
            string stringInt = Console.ReadLine();

            int parseInt = int.Parse(stringInt);

            Console.WriteLine("byteType: "+byteType);
            Console.WriteLine("sbyteType: " + sbyteType);
            Console.WriteLine("intType: " + intType);
            Console.WriteLine("uintType: " + uintType);
            Console.WriteLine("shortType: " + shortType);
            Console.WriteLine("ushortType: " + ushortType);
            Console.WriteLine("longType: " + longType);
            Console.WriteLine("ulongType: " + ulongType);
            Console.WriteLine("floatType: " + floatType);
            Console.WriteLine("doubleType: " + doubleType);
            Console.WriteLine("charType: " + charType);
            Console.WriteLine("boolType: " + boolType);
            Console.WriteLine("decimalType: " + decimalType);
            Console.WriteLine("stringType: " + stringType);
            Console.WriteLine("Parse int: " + parseInt);

        }
    }
}