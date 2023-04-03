using System.Xml;

namespace EnhancedIfStatementsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature: ");
            var input = Console.ReadLine();
            uint temperature;
            string output;

            bool valid = uint.TryParse(input, out temperature);
            if (valid) {
                output = temperature <= 15 ? "it is too cold here"
                    : temperature <= 28 ? "it is ok"
                    : "it is hot here";

                Console.WriteLine(output);

                Console.ReadLine();
            }
        }
    }
}