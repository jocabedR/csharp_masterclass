using System.Text.RegularExpressions;

namespace ParsingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\Jocabed\\source\\repos\\ParsingGame\\ParsingGame\\input2.txt");
            Regex regex = new Regex(@"\d{2}\d?");

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                GroupCollection group = match.Groups;
                int intParse = int.Parse(group[0].Value);
                Console.Write((char)intParse);
            }
        }
    }
}