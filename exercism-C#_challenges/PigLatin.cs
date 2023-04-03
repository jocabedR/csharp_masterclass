using System;

public static class PigLatin {
    public static string Translate(string word) {
        var response = "";
        var words = word.Split(' ');

        foreach(string actualWord in words) {
            var translation = false;
            string actualResponse = "";

            if (actualWord.IndexOf('y') >= 1) {
                if (actualWord.Length == 2) {
                    actualResponse = "y" + actualWord[0] + "ay";
                    translation = true;
                } else {
                    var y = actualWord.IndexOf('y');
                    bool containsVowels = false;

                    foreach(char letter in actualWord) {
                        if ("aeiou".IndexOf(letter) >= 0) {
                            containsVowels = true;
                            break;
                        }
                    }

                    if (!containsVowels ||
                        (actualWord.IndexOf('a') > y + 1 &&
                            actualWord.IndexOf('e') > y + 1 &&
                            actualWord.IndexOf('i') > y + 1 &&
                            actualWord.IndexOf('o') > y + 1 &&
                            actualWord.IndexOf('u') > y + 1
                        )) {
                        var end = actualWord.Substring(0, y);
                        var start = actualWord.Substring(y + 1);

                        actualResponse = "y" + start + end + "ay";
                        translation = true;
                    }
                }
            }

            if ("aeiouh".IndexOf(actualWord[0]) >= 0 ||
                (actualWord[0] == 'x' && !("aeiou".IndexOf(actualWord[1]) >= 0)) ||
                (actualWord[0] == 'y' && !("aeiou".IndexOf(actualWord[1]) >= 0)) &&
                !translation) {
                actualResponse = actualWord + "ay";
            } else if (!translation) {
                if (actualWord.Substring(1, 2).Equals("qu")) {
                    var end = actualWord.Substring(0, 3);
                    var start = actualWord.Substring(3);
                    actualResponse = start + end + "ay";
                } else {
                    var aux = "";
                    var before = actualWord[0];
                    foreach(char letter in actualWord) {
                        if ("aeio".IndexOf(letter) >= 0 || (letter == 'u' && before != 'q')) break;
                        aux += letter;
                        before = letter;
                    }
                    actualResponse = actualWord.Substring(aux.Length) + aux + "ay";
                }
            }
            response = response + actualResponse + " ";
        }
        return response.Trim();
    }
}