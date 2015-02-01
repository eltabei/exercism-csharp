using System.Collections.Specialized;

namespace ExercismCSharp.csharp.roman_numerals
{
    public static class Roman
    {
        static readonly OrderedDictionary romanLetters = new OrderedDictionary {
                                                                                 { 1000, "M" },
                                                                                 { 900, "CM" },
                                                                                 { 500, "D" },
                                                                                 { 400, "CD" },
                                                                                 { 100, "C" },
                                                                                 { 90, "XC" },
                                                                                 { 50, "L" },
                                                                                 { 40, "XL" },
                                                                                 { 10, "X" },
                                                                                 { 9, "IX" },
                                                                                 { 5, "V" },
                                                                                 { 4, "IV" },
                                                                                 { 1, "I" }
                                                                               };


        public static string ToRoman(this int num)
        {
            string s = string.Empty;
            foreach (int k in romanLetters.Keys)
            {
                while (num >= k)
                {
                    s += romanLetters[(object)k];
                    num -= k;
                }
            }
            return s;
        }
    }
}
