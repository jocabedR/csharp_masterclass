using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string verse = "";
        for (; takeDown >= 1; takeDown--) {
            if (startBottles == 0){
                verse += "\nNo more bottles of beer on the wall, no more bottles of beer.\n" +
                    "Go to the store and buy some more, 99 bottles of beer on the wall.";
                break;
            }
            if (startBottles == 1) {
                startBottles--;
                verse += "\n1 bottle of beer on the wall, 1 bottle of beer.\n" +
                    "Take it down and pass it around, no more bottles of beer on the wall.\n";
                continue;
            }
            verse += String.Format("\n{0} bottles of beer on the wall, {0} bottles of beer.\n", startBottles--);
            if (startBottles == 1) verse += "Take one down and pass it around, 1 bottle of beer on the wall.\n";
            else verse += String.Format("Take one down and pass it around, {0} bottles of beer on the wall.\n", startBottles);
        }

        return verse.Trim('\n');
    }
}