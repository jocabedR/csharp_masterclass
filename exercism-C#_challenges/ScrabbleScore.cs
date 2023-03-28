using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int score = 0;
        input = input.ToUpper();
        for (int idx = 0; idx < input.Length; idx++) {
            char letter = input[idx];
            if ("AEIOULNRST".IndexOf(letter) >= 0) score += 1; 
            if ("DG".IndexOf(letter) >= 0) score += 2;
            if ("BCMP".IndexOf(letter) >= 0) score += 3;
            if ("FHVWY".IndexOf(letter) >= 0) score += 4;
            if ("K".IndexOf(letter) >= 0) score += 5;
            if ("JX".IndexOf(letter) >= 0) score += 8;
            if ("QZ".IndexOf(letter) >= 0) score += 10;
        }
        return score;
    }
}