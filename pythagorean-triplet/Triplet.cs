using System;
using System.Collections.Generic;

public class Triplet
{
    public int A, B, C;
    private const double Epsilon = 0.000001;

    public Triplet(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }

    public int Sum()
    {
        return A + B + C;
    }

    public int Product()
    {
        return A * B * C;
    }

    public bool IsPythagorean()
    {
        return A * A + B * B == C * C;
    }

    public static IEnumerable<Triplet> Where(int minFactor = 1, int maxFactor = 100, int sum = 0)
    {
        for (int a = minFactor; a <= maxFactor - 2; a++)
        for (int b = a + 1; b <= maxFactor - 1; b++)
        {
            double c = Math.Sqrt(a * a + b * b);
            if (c > maxFactor)
            {
                break;
            }
            int ci = (int)c;
            if ((Math.Abs(c - ci) > Epsilon))
            {
                continue;
            }
            if (sum == 0 || sum == a + b + ci)
            {
                yield return new Triplet(a, b, ci);
            }
        }
    }
}
