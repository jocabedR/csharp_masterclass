using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var sum = 0;
        Dictionary<int,int> mult = new Dictionary<int,int>();

        foreach (int number in multiples) {
            if (number == 0) continue;
            for (int i=number; i<max; i++){
                if (i%number == 0 && !mult.ContainsKey(i)) mult.Add(i,i);
            }
        }

        foreach (var diccionary in mult) {
            sum += diccionary.Value;
        }

        return sum;
    }
}