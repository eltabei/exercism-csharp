using System;
using System.Collections.Generic;

namespace ExercismCSharp.robot_name
{
    class Robot
    {
        private static readonly Random r = new Random();
        static readonly List<string> names = new List<string>();

        public string Name { get; private set; }

        public Robot()
        {
            Reset();
        }

        public void Reset()
        {
            Name = CreateRandomName();
            while (names.Contains(Name))
            {
                Name = CreateRandomName();
            }
            names.Add(Name);
        }

        private static string CreateRandomName()
        {
            int c1 = r.Next('A', 'Z');
            int c2 = r.Next('A', 'Z');
            int num = r.Next(0, 999);
            return string.Format("{0}{1}{2:000}", (char)c1, (char)c2, num);
        }
    }
}
