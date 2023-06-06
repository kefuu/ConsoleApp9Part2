using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9Part2
{
    public static class task6
    {
        public static void task6Func(string[] args)
        {
            Func<string, string, bool> wordExistsInText = (text, word) => text.Contains(word, StringComparison.OrdinalIgnoreCase);

            string text = "SUPER CODER.";
            string word = "CODER";

            bool exists = wordExistsInText(text, word);

            if (exists)
                Console.WriteLine($"The word '{word}' exists in the text.");
            else
                Console.WriteLine($"The word '{word}' does not exist in the text.");
        }
    }
}
