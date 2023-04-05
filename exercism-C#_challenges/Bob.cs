using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        int len = statement.Length;
        bool containsLetters = false;
        statement = statement.Replace("\n", "")
                   .Replace("\t", "")
                   .Replace("\r", "")
                   .Replace(" ", "");
	
	    foreach (char letter in statement) {
            if (Char.IsLetter(letter)) {
                containsLetters = true;
                break;
            }
        }
        
        if (statement.Equals("")) return "Fine. Be that way!";
        if (statement.Contains("?") && statement.IndexOf("?") == statement.Length-1) {
            if (statement.Equals(statement.ToUpper()) 
                && containsLetters
                ) return "Calm down, I know what I'm doing!";
            else return "Sure.";
        } else {
            if (statement.Equals(statement.ToUpper()) && containsLetters) return "Whoa, chill out!";
            else return "Whatever.";
        } 
        return "";
    }
}