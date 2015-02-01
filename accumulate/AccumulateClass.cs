using System;
using System.Collections.Generic;

namespace ExercismCSharp.csharp.accumulate
{
    public static class AccumulateClass
    {
        public static IEnumerable<T2> Accumulate<T, T2>(this IEnumerable<T> cont, Func<T, T2> func)
        {
            foreach (T item in cont)
            {
                yield return func(item);
            }
        }
    }
}
