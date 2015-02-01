using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercismCSharp.twelvedays
{
    class TwelveDaysSong
    {
        private const string Start = "On the {0} day of Christmas my true love gave to me, ";
        private readonly string[] parts = new string[]
                                          {
                                              "twelve Drummers Drumming",
                                              "eleven Pipers Piping",
                                              "ten Lords-a-Leaping",
                                              "nine Ladies Dancing",
                                              "eight Maids-a-Milking",
                                              "seven Swans-a-Swimming",
                                              "six Geese-a-Laying",
                                              "five Gold Rings",
                                              "four Calling Birds",
                                              "three French Hens",
                                              "two Turtle Doves",
                                              "and a Partridge in a Pear Tree.\n"
                                          };

        private readonly string[] days = new string[]
                                         {
                                             "dummy",
                                             "first",
                                             "second",
                                             "third",
                                             "fourth",
                                             "fifth",
                                             "sixth",
                                             "seventh",
                                             "eighth",
                                             "ninth",
                                             "tenth",
                                             "eleventh",
                                             "twelfth"
                                         };

        public string Verse(int i)
        {
            string start = string.Format(Start, days[i]);
            StringBuilder s = new StringBuilder(start);
            IEnumerable<string> res = Enumerable.Range(12 - i, i)
                .Select(j => string.Format("{0}, ", parts[j]));
            s.Append(string.Join("", res));
            if (i == 1)
            {
                s = s.Replace("and ", "");
            }
            return s.ToString().TrimEnd(", ".ToCharArray());
        }

        public string Verses(int a, int b)
        {
            StringBuilder s = new StringBuilder();
            for (int i = a; i <= b; i++)
            {
                s.Append(Verse(i));
                s.Append('\n');
            }
            return s.ToString();
        }

        public string Sing()
        {
            return Verses(1, 12);
        }
    }
}