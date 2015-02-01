using System;
using System.Linq;

public class Squares
{
    private readonly int limit;

    public Squares(int i)
    {
        if (i < 0)
        {
            throw new ArgumentException();
        }
        limit = i;
    }

    public int SquareOfSums()
    {
        int a = Enumerable.Range(1, limit).Sum();
        return a * a;
    }

    public int SumOfSquares()
    {
        return Enumerable.Range(1, limit).Select(x => x * x).Sum();
    }

    public int DifferenceOfSquares()
    {
        return SquareOfSums() - SumOfSquares();
    }
}