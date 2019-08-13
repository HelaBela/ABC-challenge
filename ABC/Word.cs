using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualBasic;

namespace ABC
{
    public static class Word
    {
       // static char[] letters = new char[]{ 'A', 'B', 'C', 'D', 'E','F','G' };

        private static readonly List<char> LettersLeft = new List<char>() { 'B', 'X', 'D', 'C', 'N','G','R','T', 'Q' , 'F', 'J', 'H','V','A','O','E','F','L','P','Z'};
        
        private static readonly List<char> LettersRight = new List<char>() { 'O','K','Q','P','A','T','E','G','D','S','W','U','I','N','B','R','S','Y','C','M' };
        
        public static List<string> Words = new List<string>() {
            "A", "BARK", "BOOK", "TREAT", "COMMON", "SQUAD", "CONFUSE"
        };
        
        public static bool CanMakeWord(string word)
        {
            var workingListLeft = new List<char>(LettersLeft);
            var workingListRight = new List<char>(LettersRight);
            foreach (var eachLetter in word)
            {
                if (workingListLeft.Contains(eachLetter))
                {
                    var index = workingListLeft.IndexOf(eachLetter);

                    workingListLeft.Remove(eachLetter);

                    workingListRight.RemoveAt(index);
                }
                else if (workingListRight.Contains(eachLetter))
                {
                    var indexRight = workingListRight.IndexOf(eachLetter);
                    workingListRight.Remove(eachLetter);
                    workingListLeft.RemoveAt(indexRight);

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
