namespace JaggedArraysChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] familyfriends =
            {
                new string[] {"Joca", "Esther"},
                new string[] {"Vicky", "Jorge"},
                new string[] {"Pati", "Sofie"}
            };

            Console.WriteLine("Hi {0}, this is {1}!", familyfriends[0][0], familyfriends[1][0]);
            Console.WriteLine("Hi {0}, this is {1}!", familyfriends[1][1], familyfriends[2][0]);
            Console.WriteLine("Hi {0}, this is {1}!", familyfriends[0][1], familyfriends[2][1]);

        }
    }
}