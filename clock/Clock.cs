using System;

namespace ExercismCSharp.csharp.clock
{
    public class Clock
    {

        private const int DayMinutes = 24 * 60;
        private readonly int hours, minutes;
        protected readonly int TotalMinutes;

        public Clock(int h, int m=0)
        {
            TotalMinutes = h * 60 + m;
            if (TotalMinutes < 0)
            {
                TotalMinutes += DayMinutes;
            }
            TotalMinutes %= DayMinutes;
            hours = Math.DivRem(TotalMinutes, 60, out minutes);
        }

        public Clock Add(int m)
        {
            return new Clock(0, TotalMinutes + m);
        }

        public Clock Subtract(int m)
        {
            return Add(-m);
        }

        public override string ToString()
        {
            return string.Format("{0:00}:{1:00}", hours, minutes);
        }

        public override bool Equals(object c)
        {
            if (ReferenceEquals(null, c))
            {
                return false;
            }
            if (ReferenceEquals(this, c))
            {
                return true;
            }
            if (c.GetType() == GetType())
            {
                return TotalMinutes == ((Clock)c).TotalMinutes;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return TotalMinutes;
        }
    }
}
