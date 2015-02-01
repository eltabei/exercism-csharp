using System;
using System.Text.RegularExpressions;

public class PigLatin
{
    public static string Translate(string line)
    {
        string res = string.Empty;
        foreach (string word in line.Split())
        {
            res += TranslateWord(word) + " ";
        }
        return res.Trim();
    }

    public static string TranslateWord(string word)
    {
        word = word.ToLower();
        Regex r1 = new Regex("^([aeiou]|yt|xr)[a-z]+$");
        Regex r2 = new Regex("^(thr?|sch|ch|qu|[^aeiou](qu)?)([a-z]+)$");
        if (r1.IsMatch(word))
        {
            return word + "ay";
        }
        if (r2.IsMatch(word))
        {
            Match m = r2.Match(word);
            return m.Groups[3].Value + m.Groups[1].Value + "ay";
        }
        throw new ArgumentException();
    }
}