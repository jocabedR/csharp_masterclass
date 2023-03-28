using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string log, string after) {
        return log.Split(after)[1];
    }
    
    public static string SubstringBetween(this string log, string first, string last) {
        return log.Split(last)[0].Split(first)[1];
    }

    public static string Message(this string log) {
        return log.Split(": ")[1];
    }
    
    public static string LogLevel(this string log) {
        return log.SubstringBetween("[", "]");
    }
}