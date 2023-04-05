using System;


namespace Coding.Exercise
{
    public class Exercise
    {
        public static int NotHungryCats(string kitchen)
        {
            int notHungry = 0;
            
            if(!kitchen.Contains("F")) return notHungry;
            
            string[] catGroups = kitchen.Split('F');
            
            var firstGroup = catGroups[0].Trim();
            for(int i = 0; i < firstGroup.Length; i+=2) 
            {
                var cat = firstGroup.Substring(i, 2);
                if (cat.Equals("O~")) notHungry++;
            }

            var secondGroup = catGroups[1].Trim();
            for (int i = 0; i < secondGroup.Length-2; i += 2)
            {
                var cat = secondGroup.Substring(i, 2);
                if (cat.Equals("~O")) notHungry++;
            }

            Console.WriteLine(notHungry);
            
            return notHungry;
        }
    }
}
