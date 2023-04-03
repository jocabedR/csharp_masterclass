using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        int value = 0;
        for (int i=1, pow=0; i>=0; i--, pow++) {
            Console.WriteLine(colors[i]);
            int colorValue = 0;
            switch(colors[i]) {
                case "black": 
                    colorValue = 0;
                    break;
                case "brown": 
                    colorValue = 1;
                    break;
                case "red": 
                    colorValue = 2;
                    break;
                case "orange": 
                    colorValue = 3;
                    break;
                case "yellow": 
                    colorValue = 4;
                    break;
                case "green": 
                    colorValue = 5;
                    break;
                case "blue": 
                    colorValue = 6;
                    break;
                case "violet": 
                    colorValue = 7;
                    break;
                case "grey": 
                    colorValue = 8;
                    break;
                case "white": 
                    colorValue = 9;
                    break;
            }
            Console.WriteLine(colorValue);
            value += colorValue * (int)Math.Pow(10, pow);
        }
        return value;
    }
}
