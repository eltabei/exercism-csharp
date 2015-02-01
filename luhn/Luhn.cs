using System.Collections.Generic;
using System.Linq;

namespace ExercismCSharp.csharp.luhn
{
    public class Luhn
    {
        public int CheckDigit { get; private set; }

        public List<long> Addends { get; private set; }

        public long Checksum
        {
            get { return Addends.Sum(); }
        }

        public bool Valid
        {
            get { return Checksum % 10 == 0; }
        }

        public Luhn(long i)
        {
            CheckDigit = (int)(i % 10);
            int count = 1;
            Addends = new List<long>();
            while (i > 0)
            {
                long num = i % 10;
                if (count % 2 == 0)
                {
                    num *= 2;
                    if (num > 9)
                    {
                        num -= 9;
                    }
                }
                Addends.Insert(0, num);
                i /= 10;
                count++;
            }
        }

        public static long Create(long n)
        {
            return Enumerable.Range(0, 10).Select(i => n * 10 + i)
                .FirstOrDefault(n2 => new Luhn(n2).Valid);
        }
    }
}