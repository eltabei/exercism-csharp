using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercismCSharp.anagram
{
    class Anagram
    {
        private string Word { get; set; }

        public Anagram(string s)
        {
            Word = s;
        }

        public string[] Match(string[] words)
        {
            List<string> result = words.Where(w => IsAnagram(w, Word)).ToList();
            result.Sort();
            return result.ToArray();
        }

        static bool IsAnagram(string a, string b)
        {
            a = a.ToLower();
            b = b.ToLower();
            if (String.Equals(a, b) || a.Length != b.Length)
            {
                return false;
            }
            return a.Select(ch => ch.ToString()).All(c => Count(a, c) == Count(b, c));
        }

        static int Count(string s, string c)
        {
            return s.Length - s.Replace(c, "").Length;
        }
    }
}
