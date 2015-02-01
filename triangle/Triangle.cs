using System;

namespace ExercismCSharp.csharp.triangle
{
    public class Triangle
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;
        private const double D = 0.0000001;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public TriangleKind Kind()
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new TriangleException();
            }
            if (Math.Abs(a - b) < D && Math.Abs(b - c) < D)
            {
                return TriangleKind.Equilateral;
            }
            if (Math.Abs(a - b) < D || Math.Abs(a - c) < D || Math.Abs(b - c) < D)
            {
                return TriangleKind.Isosceles;
            }
            return TriangleKind.Scalene;
        }
    }

    public enum TriangleKind
    {
        Equilateral,
        Isosceles,
        Scalene
    }

    public class TriangleException : Exception
    {
    }
}