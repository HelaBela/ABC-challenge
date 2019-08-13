using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ABC
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            foreach (var words in Word.Words)
            {
                Console.WriteLine(Word.CanMakeWord(words));
            }

            {
                
            }
        }
    }
}