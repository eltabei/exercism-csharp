using System;

namespace ExercismCSharp.csharp.meetup
{
    public enum Schedule
    {
        First,
        Second,
        Third,
        Fourth,
        Teenth,
        Last
    }

    public class Meetup
    {
        private readonly int month;
        private readonly int year;

        public Meetup(int m, int y)
        {
            month = m;
            year = y;
        }

        public DateTime Day(DayOfWeek dayOfWeek, Schedule first)
        {
            DateTime date;
            bool last = false;
            switch (first)
            {
                case Schedule.First:
                    date = new DateTime(year, month, 1);
                    break;
                case Schedule.Second:
                    date = new DateTime(year, month, 8);
                    break;
                case Schedule.Third:
                    date = new DateTime(year, month, 15);
                    break;
                case Schedule.Fourth:
                    date = new DateTime(year, month, 22);
                    break;
                case Schedule.Teenth:
                    date = new DateTime(year, month, 13);
                    break;
                case Schedule.Last:
                    date = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
                    last = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("first");
            }
            return Find(date, dayOfWeek, last);
        }

        static DateTime Find(DateTime t, DayOfWeek d, bool last = false)
        {
            int step = last ? -1 : 1;
            while (t.DayOfWeek != d)
            {
                t = t.AddDays(step);
            }
            return t;
        }
    }
}