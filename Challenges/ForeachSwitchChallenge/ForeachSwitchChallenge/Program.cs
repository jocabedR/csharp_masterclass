using System.Reflection.Metadata.Ecma335;

namespace ForeachSwitchChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value, type = "";
            
            Console.Write("Plis enter a value: ");
            value = Console.ReadLine();
            do
            {
                Console.WriteLine("\nPlis enter the value's type. " +
                "\nPress 1 for String" +
                "\nPress 2 for integer" +
                "\nPress 3 for Boolean");
                type = Console.ReadLine();
            } while (!type.Equals("1") && !type.Equals("2") && !type.Equals("3"));

            bool valid = true;

            switch (type)
            {
                case "1":
                    foreach(char l in value){
                        if (!Char.IsLetter(l)) valid = false;  break;
                    }
                    if (valid) Console.Write("\n{0} is an invalid string.", value);
                    else Console.Write("{0} is a valid string.", value);
                    break;
                case "2":
                    int valueInt;
                    valid = int.TryParse(value, out valueInt);
                    if (valid) Console.Write("\n{0} is an invalid integer.", valueInt);
                    else Console.Write("{0} is a valid integer.", value);
                    break;
                case "3":
                    bool valueBool;
                    valid = bool.TryParse(value, out valueBool);
                    if (valid) Console.Write("\n{0} is a valid Boolean.", valueBool);
                    else Console.Write("{0} is a valid Boolean.", value);
                    break;
            }
        } 
    }
} 