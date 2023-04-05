using System;

namespace Coding.Exercise
{   
    
    public class Run
    {
        public delegate float OperationDelegate (float a, float b);
    
        public static float ApplyOperation(float a, float b, OperationDelegate operation ) {
            return operation(a, b);
        }
        
        public static float Add(float a, float b) {
            return a + b;
        }
        
        public static float Subtract(float a, float b) {
            return a - b;
        }
        
        public static float Multiply(float a, float b) {
            return a * b;
        }
        
        public static float Divide(float a, float b) {
            return a / b;
        }
    }
}