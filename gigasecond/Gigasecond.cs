using System;

namespace ExercismCSharp.csharp.gigasecond
{
    public class Gigasecond
    {
        private DateTime dt;

        public Gigasecond(DateTime dateTime)
        {
            dt = dateTime;
        }

        public DateTime Date()
        {
            return dt.AddSeconds(1E9).Date;
        }
    }
}