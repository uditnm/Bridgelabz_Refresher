using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class VowelorConsonant
    {
        public void checkAlphabet(char c)
        {
            if(c== 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine("It is a vowel");
            }
            else
            {
                Console.WriteLine("It is a consonant");
            }
        }
    }
}
