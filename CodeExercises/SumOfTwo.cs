using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int SumOfTwo(int[] nums, int SumToFind)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int result = 0;

            foreach (int num in nums)
            {
                int complement = SumToFind - num;

                if(dictionary.ContainsKey(complement) && dictionary[complement] > 0)
                {
                    dictionary[complement]--;
                    result++;
                }
                else
                {
                    if(dictionary.ContainsKey(num)) dictionary[num]++;
                    else dictionary.Add(num, 1);
                }
            }

            return result;
        }
    }
}
