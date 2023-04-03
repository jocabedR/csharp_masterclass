using System;

public static class Proverb
{
    
    
    public static string[] Recite(string[] subjects)
    {
        var size = subjects.Length;
        string[] proverb = new String[size];
        
        for(int i = 0; i < proverb.Length-1; i++) {
            proverb[i] = String.Format("For want of a {0} the {1} was lost.", subjects[i], subjects[i+1]);
        }

        if(size > 0) {
            proverb[proverb.Length-1] = String.Format("And all for the want of a {0}.", subjects[0]);
        }

        return proverb;
    }
}