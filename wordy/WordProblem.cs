using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExercismCSharp.csharp.wordy
{
    public class WordProblem
    {
        private static string problem;
        private static readonly Regex problemRegex = new Regex(@"(<b>-?\d+<b>| plus | minus | multiplied | divided )+");
        private static readonly Regex tokenRegex = new Regex(@"-?\d+");

        private static readonly Dictionary<string, Func<int, int, int>> operators =
            new Dictionary<string, Func<int, int, int>>
                                                    {
                                                        { "plus", (x, y) => x + y },
                                                        { "minus", (x, y) => x - y },
                                                        { "multiplied", (x, y) => x * y },
                                                        { "divided", (x, y) => x / y }
                                                    };

        public static int Solve(string s)
        {
            problem = s.Replace("What is ", string.Empty).Replace("by ", string.Empty).TrimEnd('?');
            int res = 0;
            string op = string.Empty;

            if (!problemRegex.IsMatch(problem))
            {
                throw new ArgumentException();
            }

            foreach (string token in problem.Split())
            {
                if (tokenRegex.IsMatch(token))
                {
                    int num = int.Parse(token);
                    if (string.IsNullOrEmpty(op))
                    {
                        res = num;
                    }
                    else
                    {
                        res = operators[op](res, num);
                    }
                }
                else
                {
                    op = token;
                }
            }
            return res;
        }
    }
}