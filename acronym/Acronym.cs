using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExercismCSharp.csharp.acronym
{
    public class Acronym
    {
        public static string Abbreviate(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            List<string> words = s.Split(new char[] { ' ', '-' }).ToList();
            string abb = string.Empty;
            foreach (string w in words)
            {
                string a = string.Empty;
                if (w == w.ToUpper())
                {
                    a += w[0];
                }
                else
                {
                    foreach (Match m in Regex.Matches(w, @"^\w|[A-Z]"))
                    {
                        a += m.Value.ToUpper();
                    }
                }
                abb += a;
            }
            return abb;
        }
    }
}