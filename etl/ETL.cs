using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercismCSharp.etl
{
    class ETL
    {
        public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> given)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (int i in given.Keys)
            {
                foreach (string s in given[i])
                {
                    result[s.ToLower()] = i;
                }
            }
            return result;
        }
    }
}
