using System;
using System.Collections.Generic;
using CountSubstringModels;

namespace ConsoleApp
{
    class Program
    {
        private static void Main()
        {
            var countSubstring = new CountSubstringInList();

            //var substrings = countSubstring.GetAllSubstring("Howdy partner, sit down! How's it going?");

            //substrings.ForEach(Console.WriteLine);

            var substrings = new List<string>()
            {
                "below", "down", "go", "going", "horn", "how", "howdy", "it", "i", "low", "own", "part", "partner",
                "sit"
            };

            var text = "Howdy partner, sit down! How's it going?";

            var substringInTextCount = countSubstring.CountSubstringsOfString(text, substrings);
            
            foreach (var keyValuePair in substringInTextCount)
            {
                Console.WriteLine(keyValuePair);
            }
        }
    }
}