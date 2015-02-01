using System;

namespace ExercismCSharp.hamming
{
    static class Hamming
    {
        public static int Compute(string a, string b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException();
            }
            if (a.Length != b.Length)
            {
                throw new ArgumentException();
            }
            int c = 0;
            for (int i = 0; i < a.Length; i++ )
            {
                if (a[i] != b[i])
                {
                    c++;
                }
            }
            return c;
        }
    }
}
