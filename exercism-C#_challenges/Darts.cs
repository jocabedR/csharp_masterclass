using System;

public static class Darts
{
    const int outer = 10;
    const int middle = 5;
    const int inner = 1;
    public static int Score(double x, double y)
    {
        double radious = Math.Sqrt(x*x + y*y);
        if(radious > outer) return 0;
        if(radious <= inner) return 10;
        if(radious > inner &&  radious <= middle) return 5;
        return 1;
    }
}
