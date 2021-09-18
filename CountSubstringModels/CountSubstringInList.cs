using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CountSubstringModels
{
    public class CountSubstringInList
    {
        public CountSubstringInList()
        {
            
        }

        public Dictionary<string, int> CountSubstringsOfString(string text, List<string> substrings)
        {
            Dictionary<string, int> countSubstrings= new();
            foreach (var word in substrings)
            {
                var count = Regex.Matches(text.ToLower(), word.ToLower()).Count;
                if (count > 0)
                {
                    countSubstrings[word] = count;
                }
            }
            return countSubstrings;
        }

        public List<string> GetAllSubstring(string str)
        {
            List<string> substrings = new();
            for (int i = 0; i < str.Length; i++)
            {
                var substring = "";
                
                if (char.IsLetter(str[i])) {
                    substring = str[i].ToString();
                    substrings.Add(substring);
                }
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (!char.IsLetter(str[j])) continue;
                    
                    substring += str[j].ToString();
                    substrings.Add(substring);
                }
            }
            return substrings.ToList();
        }
    }
}