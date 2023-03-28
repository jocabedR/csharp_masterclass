using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void Run()
        {
            int i = -10;
            
            while(true){
                
                if (i%3 == 0){
                    i++;
                    continue;   
                }  
                if (i == 10)
                {
                    break;
                }
                Console.WriteLine(i++);    
            }
        }
    }
}
