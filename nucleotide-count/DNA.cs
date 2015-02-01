using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercismCSharp.nucleotide_count
{
    class DNA
    {
        private readonly Dictionary<char, int> counts = new Dictionary<char, int>();
        private readonly char[] chars = new char[] { 'A', 'T', 'C', 'G' };

        public DNA(string s)
        {
            foreach (char c in chars)
            {
                counts[c] = 0;
            }
            foreach (char c in s)
            {
                counts[c] += 1;
            }
        }

        public Dictionary<char, int> NucleotideCounts
        {
            get { return counts; }
        }

        public int Count(char c)
        {
            if (!chars.Contains(c))
            {
                throw new InvalidNucleotideException();
            }
            return counts[c];
        }
    }

    class InvalidNucleotideException : ArgumentException
    {
        
    }
}
