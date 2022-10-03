using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string justLetters = "";
            foreach (char c in str)
            {
                if (alphabet.Contains(char.ToLower(c)))
                {
                    justLetters += char.ToLower(c);
                }
            }
            Console.WriteLine($"The value for justLetters is: {justLetters}");
            if (justLetters.Length < 2) return false;
            else
            {
                for (int i = 0; i < justLetters.Length / 2; i++)
                    if (justLetters[i] != justLetters[justLetters.Length - i - 1]) return false;
                return true;
            }
        }
    }
}
