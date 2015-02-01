using System.Linq;

public class Complement
{
    private const string Dna = "GCTA";
    private const string Rna = "CGAU";

    public static string OfDna(string s)
    {
        return ConvertHelper(s, Dna, Rna);
    }

    public static string OfRna(string s)
    {
        return ConvertHelper(s, Rna, Dna);
    }

    private static string ConvertHelper(string s, string keys, string values)
    {
        return string.Join("", s.Select(c => values[keys.IndexOf(c)]));
    }
}