using System.Collections.Generic;

namespace ExercismCSharp.grade_school
{
    class School
    {
        public Dictionary<int, List<string>> Roster = new Dictionary<int, List<string>>();

        public void Add(string name, int grade)
        {
            if (Roster.ContainsKey(grade))
            {
                Roster[grade].Add(name);
            }
            else
            {
                Roster[grade] = new List<string> { name };
            }
            Roster[grade].Sort();
        }

        public List<string> Grade(int g)
        {
            return !Roster.ContainsKey(g) ? new List<string>() : Roster[g];
        }
    }
}
