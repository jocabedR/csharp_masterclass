using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    private string BaseWord { get; set;}
    
    public Anagram(string baseWord)
    {
        BaseWord = baseWord.ToLower();
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> finded = new List<string>();
        
        foreach(string potencial in potentialMatches) 
        {
            if(potencial.Length == BaseWord.Length) 
            {
                if(BaseWord.Equals(potencial.ToLower())) continue;
                if(!hasSameCharacters(potencial.ToLower())) continue;
                finded.Add(potencial);
            }
        }
        return finded.ToArray();
    }

    public bool hasSameCharacters(string potencial) 
    {
        foreach(char character in potencial)
        {
            if(!BaseWord.Contains(character)) return false;
            var frecuency1 = potencial.Count(f => (f == character));
            var frecuency2 = BaseWord.Count(f => (f == character));
            if(frecuency1 != frecuency2) return false;
        }
        return true;
    }
}