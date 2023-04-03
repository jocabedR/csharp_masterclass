namespace PropertiesChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(4, -4, 5);

            box.Length = 4;
            box.Height = -4;
            box.Width = 5;

            box.DisplayInfo();

            Console.WriteLine("volume is {0}", box.Volumen);
            Console.WriteLine("front surface of the box is {0}", box.FrontSurface);
            Console.ReadLine();
        }
    }
}