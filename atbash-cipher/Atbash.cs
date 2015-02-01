public class Atbash
{
    public static string Encode(string words)
    {
        string res = string.Empty;
        int count = 0;

        foreach (char c in words.ToLower())
        {
            if (char.IsLetter(c))
            {
                char r = (char)('z' - c + 'a' );
                res += r;
            }
            else if (char.IsDigit(c))
            {
                res += c;
            }
            else
            {
                continue;
            }
            count++;
            if (count % 5 == 0)
            {
                res += ' ';
            }
        }
        return res.Trim();
    }
}
