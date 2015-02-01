using System.Collections.Generic;
using System.Collections.Specialized;

namespace ExercismCSharp.csharp.allergies
{
    public class Allergies
    {
        private readonly int n;
        readonly List<string> list = new List<string>(); 
        private readonly OrderedDictionary allergiesDict = new OrderedDictionary
                                                           {
                                                               { "eggs", 1 },
                                                               { "peanuts", 2 },
                                                               { "shellfish", 4 },
                                                               { "strawberries", 8 },
                                                               { "tomatoes", 16 },
                                                               { "chocolate", 32 },
                                                               { "pollen", 64 },
                                                               { "cats", 128 }
                                                           };


        public Allergies(int i)
        {
            n = i;
            foreach (string food in allergiesDict.Keys)
            {
                if (AllergicTo(food))
                {
                    list.Add(food);
                }
            }

        }

        public bool AllergicTo(string food)
        {
            int a = (int)allergiesDict[food];
            return (n & a) == a;
        }

        public List<string> List()
        {
            return list;
        }
    }
}