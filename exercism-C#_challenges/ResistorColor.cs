using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        switch(color) {
            case "black": 
                return 0;
            case "brown": 
                return 1;
            case "red": 
                return 2;
                break;
            case "orange": 
                return 3;
                break;
            case "yellow": 
                return 4;
                break;
            case "green": 
                return 5;
                break;
            case "blue": 
                return 6;
                break;
            case "violet": 
                return 7;
                break;
            case "grey": 
                return 8;
                break;
            case "white": 
                return 9;
                break;
        }
        return 0;
    }

    public static string[] Colors()
    {
        string[] colors = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        return colors;
    }
}