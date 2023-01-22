using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public int GetVowelCount(string str)
    {
        string _str = str;

        int vowelCount = 0;

        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        char[] stringArray = _str.ToCharArray();

        int i = 0;

        while (i < _str.Length)
        {
            char currentLetter = stringArray[i];

            if (vowels.Contains(currentLetter) && currentLetter != 'y' && currentLetter != ' ')
            {
                Console.WriteLine(char.ToUpper(currentLetter) + " is a vowel.");
                vowelCount++;
            }
            else
            {
                Console.WriteLine(char.ToUpper(currentLetter) + " is NOT a vowel.");
            }

            i++;
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine(_str.ToUpper() + " contains " + vowelCount + " vowels.");

        return vowelCount;
    }
}
