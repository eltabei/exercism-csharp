using System;
using System.Collections.Generic;

public class Crypto
{
    private readonly string text;
    public int Size { get; private set; }
    public string NormalizePlaintext { get; private set; }

    public Crypto(string text)
    {
        this.text = text;
        NormalizeText();
        CalculateSize();
    }

    void NormalizeText()
    {
        string res = string.Empty;
        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                res += char.ToLower(c);
            }
        }
        NormalizePlaintext = res;
    }

    void CalculateSize()
    {
        int l = NormalizePlaintext.Length;
        double r = Math.Sqrt(l);
        const double e = 0.00001;
        if (Math.Abs(r - Math.Floor(r)) < e)
        {
            Size = (int)r;
        }
        else
        {
            Size = (int)Math.Ceiling(r);
        }
    }

    public List<string> PlaintextSegments()
    {
        List<string> segments = new List<string>();
        int len = NormalizePlaintext.Length;
        for (int i = 0; i < len; i += Size)
        {
            segments.Add(NormalizePlaintext.Substring(i, Math.Min(Size, len - i)));
        }
        return segments;
    }

    public string Ciphertext()
    {
        string ciphText = string.Empty;
        List<string> segments = PlaintextSegments();
        for (int iChar = 0; iChar < Size; iChar++)
        {
            foreach (string seg in segments)
            {
                if (iChar < seg.Length)
                {
                    ciphText += seg[iChar];
                }
            }
        }
        return ciphText;
    }

    public string NormalizeCiphertext()
    {
        string res = string.Empty;
        int count = 0;
        foreach (char c in Ciphertext())
        {
            res += c;
            count++;
            if (count % 5 == 0)
            {
                res += ' ';
            }
        }
        return res.Trim();
    }
}