using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int a, b, c;
        for(a = 1; a < sum; a++) {
            for(b = a + 1; b < sum; b++) {
                c = (int)Math.Sqrt(a * a + b * b);
                if(a + b + c == sum && c * c == a * a + b * b) {
                    yield return (a, b, c);
                }
            }
        }
    }
}