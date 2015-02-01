using System.Linq;
using System.Collections.Generic;

namespace ExercismCSharp.csharp.raindrops
{
    public class Raindrops
    {
        public static string Convert(int number)
        {
            Dictionary<int, string> dropsWords = new Dictionary<int, string>
                                                 {
                                                     { 3, "Pling" },
                                                     { 5, "Plang" },
                                                     { 7, "Plong" }
                                                 };
            IEnumerable<string> words = dropsWords.Keys.Where(i => number % i == 0).Select(i => dropsWords[i]);
            string ans = string.Join("", words);
            return string.IsNullOrEmpty(ans) ? number.ToString() : ans;
        }
    }
}