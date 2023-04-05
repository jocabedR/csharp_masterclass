using System;
using System.Collections.Generic;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        Dictionary<int,int> work = new Dictionary<int,int>();

        for(int i=0; i<input.Length; i++) {
            work.Add(i, input[i]);
        }
        
        int middle = (input.Length-1) / 2;
        while(true){
            if(!work.ContainsKey(middle) || work.Count==0) break;
            if(work[middle] == value) return middle;
            if(work[middle] > value)
            {
                for(int i=middle;  i<=input.Length; i++)
                {
                     if(work.ContainsKey(i)) work.Remove(i);
                }
                middle = middle/2;
            } else 
            {
                for(int i=0;  i<=middle; i++)
                {
                     if(work.ContainsKey(i)) work.Remove(i);
                }
                middle = middle + (middle/2);
            }
        }

        return -1;
    }
}