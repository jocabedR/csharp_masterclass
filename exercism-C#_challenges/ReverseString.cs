using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string reverse = "";
        for(int i = input.Length-1; i >= 0; i--) {
            reverse += input[i];
        }
        return reverse;
    }
}