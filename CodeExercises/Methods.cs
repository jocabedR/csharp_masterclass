using System;

namespace Coding.Exercise
{
    public class Method
    {
        public static string LowUpper(string input){
            string low = input.ToLower();
            string upper = input.ToUpper();
            
            return string.Concat(low, upper);
        }
        
        public static void Count(string input){
            Console.WriteLine("The amount of characters is {0}.", input.Length);
        }
        
        public static void Run()
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";
            
            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
            
        }
        
        
    }
}
