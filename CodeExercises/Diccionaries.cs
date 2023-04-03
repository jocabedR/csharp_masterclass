using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Speller
    {
        public static string Convert(int i)
        {
            // TODO
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "zero");
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");
            dictionary.Add(5, "five");
            
            if (dictionary.ContainsKey(i)) return dictionary[i];
            return "nope";
        }
    }
}
