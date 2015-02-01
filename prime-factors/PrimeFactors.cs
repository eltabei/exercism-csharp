using System;
using System.Collections.Generic;

public class PrimeFactors
{
    public static long[] For(long i)
    {
        List<long> divisors = new List<long>();
        int j = 2;
        double limit = Math.Sqrt(i);
        while (j <= limit)
        {
            if (i % j == 0)
            {
                divisors.Add(j);
                i /= j;
                limit = Math.Sqrt(i);
            }
            else
            {
                j++;
            }
        }
        if (i > 1)
        {
            divisors.Add(i);
        }
        return divisors.ToArray();
    }
}