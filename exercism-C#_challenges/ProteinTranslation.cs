using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        Dictionary<string, string> proteins = new Dictionary<string, string>{
            {"AUG", "Methionine"},
            {"UUU", "Phenylalanine"},
            {"UUC", "Phenylalanine"},
            {"UUA", "Leucine"},
            {"UUG", "Leucine"},
            {"UCU", "Serine"},
            {"UCC", "Serine"},
            {"UCA", "Serine"},
            {"UCG", "Serine"},
            {"UAU", "Tyrosine"},
            {"UAC", "Tyrosine"},
            {"UGU", "Cysteine"},
            {"UGC", "Cysteine"},
            {"UGG", "Tryptophan"},
            {"UAA", "STOP"},
            {"UAG", "STOP"},
            {"UGA", "STOP"}
        };
        List<string> listProteins = new List<string>();

        var aux = "";
        int i = 0;
        while (i < strand.Length) {
            aux += strand[i];
            i++;
    
            if (aux.Length%3 == 0){
                var protein = proteins[aux];
                if (protein == "STOP") break;
                listProteins.Add(protein);
                aux = "";
            }
        }
    
        return listProteins.ToArray();
    }
}