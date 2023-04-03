using System;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string number = "";

        for(int pow=0; pow < 4; pow++){
            int digit = value%10;
            value = value/10;
            Console.WriteLine(digit);

            switch(pow) {
                case 0:
                    if(digit <= 3) {
                        for(int i=0; i<digit; i++) number += "I";
                    }
                    else if (digit == 4) number = "IV";
                    else if(digit >= 5 && digit < 9) {
                        number = "V";
                        for(int i=0; i< digit%5; i++) number += "I";
                    }
                    else number = "IX";
                    Console.WriteLine(number);
                break;
                case 1:
                    if(digit <= 3) {
                        for(int i=0; i<digit; i++) number = "X" + number;
                    }
                    else if (digit == 4) number = "XL" + number;
                    else if(digit >= 5 && digit < 9) {
                        string aux = "L";
                        for(int i=0; i< digit%5; i++) aux += "X";
                        number = aux + number;
                    }
                    else number = "XC" + number;
                    Console.WriteLine(number);
                break;
                case 2:
                    if(digit <= 3) {
                        for(int i=0; i<digit; i++) number = "C" + number;
                    }
                    else if (digit == 4) number = "CD" + number;
                    else if(digit >= 5 && digit < 9) {
                        string aux = "D";
                        for(int i=0; i< digit%5; i++) aux += "C";
                        number = aux + number;
                    }
                    else number = "CM" + number;
                    Console.WriteLine(number);
                break;
                case 3:
                    for(int i=0; i<digit; i++) number = "M" + number;
                break;
            }
        }

        return number;
    }
}