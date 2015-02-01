using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercismCSharp.csharp.series
{
    public class Series
    {
        private readonly string str;

        public Series(string input)
        {
            if (input.Any(c => !char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid number");
            }
            str = input;
        }

        public List<List<int>> Slices(int length)
        {
            if (length > str.Length)
            {
                throw new ArgumentException();
            }
            List<List<int>> res = new List<List<int>>();
            for (int i = 0; i + length <= str.Length; i++)
            {
                string sub = str.Substring(i, length);
                List<int> num = sub.Select(x => x - '0').ToList();
                res.Add(num);
            }
            return res;
        }
    }
}