using System.Collections.Generic;
using System.Linq;

namespace ExercismCSharp.csharp.sieve
{
    public class Sieve
    {
        private readonly int limit;

        public Sieve(int i)
        {
            limit = i;
        }

        public List<int> Primes
        {
            get
            {
                if (limit == 2)
                {
                    return new List<int> { 2 };
                }
                List<int> numbers = Enumerable.Range(2, limit - 2).ToList();
                for (int i = 0; i < numbers.Count; i++)
                {
                    int n = 2 * numbers[i];
                    while (n < limit)
                    {
                        if (numbers.Contains(n))
                        {
                            numbers.Remove(n);
                        }
                        n += numbers[i];
                    }
                }
                return numbers;
            }
        }
    }
}