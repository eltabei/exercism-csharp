using System;

namespace ExercismCSharp.csharp.trinary
{
    public class Trinary
    {
        private readonly string trinary;

        public Trinary(string value)
        {
            trinary = value;
        }

        public int ToDecimal()
        {
            int dec = 0;
            for (int i = 0; i < trinary.Length; i++)
            {
                char d = trinary[trinary.Length - i - 1];
                if (d != '0' && d != '1' && d != '2')
                {
                    return 0;
                }
                if (d == '1' || d == '2')
                {
                    dec += int.Parse(d.ToString()) * (int)Math.Pow(3, i);
                }
            }
            return dec;
        }
    }
}