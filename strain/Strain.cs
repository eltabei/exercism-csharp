using System;
using System.Collections.Generic;

namespace ExercismCSharp.csharp.strain
{
    public static class Strain
    {
        public static IEnumerable<T> Keep<T>(this IEnumerable<T> cont, Predicate<T> pred)
        {
            foreach (T item in cont)
            {
                if (pred(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Discard<T>(this IEnumerable<T> cont, Predicate<T> pred)
        {
            return Keep(cont, i => !pred(i));
        }
    }
}
