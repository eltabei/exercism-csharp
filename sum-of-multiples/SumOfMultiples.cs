using System.Collections.Generic;
using System.Linq;

namespace ExercismCSharp.sum_of_multiples
{
    class SumOfMultiples
    {
        private readonly List<int> divs;

        public SumOfMultiples()
        {
            divs = new List<int> { 3, 5 };
        }

        public SumOfMultiples(List<int> l)
        {
            divs = l;
        }

        public int To(int limit)
        {
            return Enumerable.Range(0, limit)
                .Where(r => divs.Any(d => r % d == 0)).Sum();
        }
    }
}
