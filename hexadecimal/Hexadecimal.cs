using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercismCSharp.csharp.hexadecimal
{
    public class Hexadecimal
    {
        private static readonly Dictionary<char, int> vals = new Dictionary<char, int>
                                                             {
                                                                 { '0', 0 },
                                                                 { '1', 1 },
                                                                 { '2', 2 },
                                                                 { '3', 3 },
                                                                 { '4', 4 },
                                                                 { '5', 5 },
                                                                 { '6', 6 },
                                                                 { '7', 7 },
                                                                 { '8', 8 },
                                                                 { '9', 9 },
                                                                 { 'a', 10 },
                                                                 { 'b', 11 },
                                                                 { 'c', 12 },
                                                                 { 'd', 13 },
                                                                 { 'e', 14 },
                                                                 { 'f', 15 },
                                                             };

        public static int ToDecimal(string hexidecimal)
        {
            try
            {
                List<char> s = hexidecimal.ToLower().Reverse().ToList();
                int result = 0;

                for (int i = 0; i < hexidecimal.Length; i++)
                {
                    result += vals[s[i]] * (int)Math.Pow(16, i);
                }
                return result;
            }
            catch (KeyNotFoundException)
            {
                return 0;
            }
        }
    }
}
