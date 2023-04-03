using System;
using System.Collections.Generic;
namespace Coding.Exercise
{
     public class ListsExercise {
        
        public static List<int> Solution()  {
            List<int> numbers = new List<int>(70);
            for(int i = 100; i <= 170; i++){
                if(i%2 == 0) numbers.Add(i);
            }
            
            return numbers;
         }

    }
}
