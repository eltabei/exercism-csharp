using System.Collections.Generic;

namespace ExercismCSharp.word_count
{
    class Phrase
    {
        private readonly string line;
        readonly char[] separators = new char[] { ' ', ',', ':', ';', '.', '/', '\\'  };
        const string Punctuation = "`~!@#$%^&*()-+=[]{}";

        public Phrase(string s)
        {
            line = s.ToLower();
        }

        public Dictionary<string, int> WordCount()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (string w in line.Split(separators))
            {
                if (string.IsNullOrEmpty(w))
                {
                    continue;
                }
                string w2 = RemovePunctuation(w);
                if (result.ContainsKey(w2))
                {
                    result[w2] += 1;
                }
                else
                {
                    result[w2] = 1;
                }
            }
            return result;
        }

        static string RemovePunctuation(string w)
        {
            string w2 = w;
            foreach (char c in Punctuation)
            {
                w2 = w2.Replace(c.ToString(), "");
            }
            return w2;
        }
    }
}
