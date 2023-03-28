using System;

public class Player
{
    Random rnd = new Random();
    public int RollDie()
    {
        return rnd.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        double random = rnd.NextDouble();
        if (random != 1.0) return random * 100;
        else return GenerateSpellStrength();
    }
}
