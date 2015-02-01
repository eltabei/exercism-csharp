using System;
using System.Linq;

class Cipher
{
    private static readonly Random r = new Random();

    public string Key { get; private set; }

    public Cipher(string key = null)
    {
        if (key == null)
        {
            CreateRandomKey();
        }
        else
        {
            if (!IsValidKey(key))
            {
                throw new ArgumentException("Invalid key");
            }
            Key = key;
        }
    }

    private void CreateRandomKey()
    {
        for (int i = 0; i < 100; i++)
        {
            Key += (char)r.Next('a', 'z');
        }
    }

    private static bool IsValidKey(string key)
    {
        return key.All(c => char.IsLetter(c) && char.IsLower(c));
    }

    public string Encode(string text)
    {
        string res = string.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            res += EncodeChar(text[i], i);
        }
        return res;
    }

    private char EncodeChar(char c, int i)
    {
        int letterOrd = c - 'a';
        int keyOrd = Key[i % Key.Length] - 'a';
        int outOrd = ((letterOrd + keyOrd) % 26) + 'a';
        return (char)outOrd;
    }

    public string Decode(string text)
    {
        string res = string.Empty;
        for (int i = 0; i < text.Length; i++)
        {
            res += DecodeChar(text[i], i);
        }
        return res;
    }

    private char DecodeChar(char c, int i)
    {
        int letterOrd = c - 'a';
        int keyOrd = Key[i % Key.Length] - 'a';
        int outOrd;
        if (letterOrd >= keyOrd)
        {
            outOrd = ((letterOrd - keyOrd) % 26) + 'a';
        }
        else
        {
            outOrd = ((letterOrd - keyOrd) + 26) + 'a';
        }
        return (char)outOrd;
    }
}