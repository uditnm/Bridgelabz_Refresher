using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class SplitWords
    {
        public void split()
        {
            string path = @"D:\bridgelabz\Bridgelabz_Refresher\PracticeProblems\";
            List<string> words = Regex.Split(File.ReadAllText(path + "file.txt"), @"[\s,;:.!?-]+").ToList();
            Console.WriteLine("Enter the word: ");
            string word = Console.ReadLine();
            if (words.Contains(word))
            {
                words.Remove(word);
            }
            else
            {
                words.Add(word);
            }
            StreamWriter sw = new StreamWriter(path + "op.txt");
            foreach (string detail in words)
            {
                sw.WriteLine(detail);
            }
            sw.Close();

            Console.WriteLine("The list in output file is:");
            string[] lines = File.ReadAllLines(path + "op.txt");

            foreach (string line in lines)
                Console.WriteLine(line);
        }
    }
}
