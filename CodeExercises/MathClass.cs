using System;

namespace Coding.Exercise
{
    
    public class Exercise
    {
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
        
        public static void Run(string line){
            int integer;
            
            var valid = int.TryParse(line, out integer);
            if(!valid || integer<0 || integer>180) {
                Console.WriteLine("Check the input!");
                return;
            } 
            Console.WriteLine("Cos = {0}", Math.Cos(ConvertToRadians(integer)));
            Console.WriteLine("Sin = {0}", Math.Sin(ConvertToRadians(integer)));
            Console.WriteLine("Tg = {0}", Math.Tan(ConvertToRadians(integer)));
        }
    }
}
