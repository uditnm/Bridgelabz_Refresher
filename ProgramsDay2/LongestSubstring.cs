using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class LongestSubstring
    {
        public void longestsubstr(string s)
        {
            int maxlength = 0;
            HashSet<char> chars = new HashSet<char>();

            int left = 0, right = 0;
            while (right < s.Length)
            {
                while (chars.Contains(s[right]))
                {
                    chars.Remove(s[left]);
                    left++;
                }
                chars.Add(s[right]);
                right++;
                maxlength = Math.Max(maxlength, right - left);
            }

            Console.WriteLine("Max length of substring: " + maxlength);
        }
    }
}
