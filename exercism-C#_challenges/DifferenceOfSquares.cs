using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        for (int i = 1; i <= max; i++){
            sum += i;
        }
        return sum * sum;
        throw new NotImplementedException("You need to implement this function.");
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;           
        for (int i = 1; i <= max; i++){
                    sum += i * i;
        }
        return sum;
        throw new NotImplementedException("You need to implement this function.");
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
        throw new NotImplementedException("You need to implement this function.");
    }
}