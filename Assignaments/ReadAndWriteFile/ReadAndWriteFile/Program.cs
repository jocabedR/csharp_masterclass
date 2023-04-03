

namespace ReadAndWriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\Jocabed\\source\\repos\\ReadAndWriteFile\\ReadAndWriteFile\\input.txt");

            string[] splitIt;
            string sentence = "";

            foreach (string line in lines) {
                if (line.Contains("split")) {
                    splitIt = line.Split(' ');

                    sentence += " " + splitIt[4];
                }
            }

            sentence = sentence.Trim();

            File.WriteAllText(@"C:\Users\Jocabed\source\repos\ReadAndWriteFile\ReadAndWriteFile\output.txt", sentence);

            Console.WriteLine(sentence);

        }

        
    }
}