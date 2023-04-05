using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Run
    {
        static Func<float, float, float> Plus = (a, b) => a+b;
        static Func<float, float, float> Minus = (a, b) => a-b;
        static Func<float, float, float> Multiply  = (a, b) => a*b;
        static Func<float, float, float> Divide  = (a, b) => a/b;
        
        static Dictionary<string, Func<float, float, float>> Operations = new Dictionary<string, Func<float, float, float>>{
            {"+", Plus},
            {"-", Minus},
            {"*", Multiply},
            {"/", Divide}
        };
            
        public static Func<float, float, float> OperationGet(string input) {
            if (Operations.ContainsKey(input)) {
                return Operations[input];
            } 
            return null;
        }
    }
}
