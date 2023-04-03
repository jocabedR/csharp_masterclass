using System;

namespace LoopsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float averange;
            int sum = 0;
            string input = "";
            int actual;
            int numStudents = 0;

            do
            {
                Console.WriteLine("Insert score of the student: ");
                input = Console.ReadLine();

                if (input == "-1") break;

                bool valid = int.TryParse(input, out actual);
                if (!valid && actual >= 0 && actual <=20)
                {
                    Console.Write("{0} is an invalid input.", input);
                }
                else { 
                    sum += actual;
                    numStudents++;
                }
            } while (true);

            averange = (float) sum / numStudents;

            Console.WriteLine("Total students :{0}", numStudents);
            Console.WriteLine("Sumatory: {0}", sum);
            Console.WriteLine("Averange: {0}", averange);

        }
    }
}