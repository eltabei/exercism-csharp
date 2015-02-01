using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExercismCSharp.csharp.tournament
{
    class Tournament
    {
        public static void Tally(MemoryStream inStream, MemoryStream outStream)
        {
            Dictionary<string, int> wins = new Dictionary<string, int>();
            Dictionary<string, int> draws = new Dictionary<string, int>(); 
            Dictionary<string, int> losses = new Dictionary<string, int>(); 
            Dictionary<string, int> points = new Dictionary<string, int>(); 

            string input = Encoding.UTF8.GetString(inStream.ToArray()).Trim();
            foreach (string line in input.Split('\n'))
            {
                List<string> tokens = line.Split(';').ToList();
                if (line.StartsWith("#") || tokens.Count != 3)
                {
                    continue;
                }

                switch (tokens[2])
                {
                    case "win":
                        Inc(wins, tokens[0]);
                        Inc(wins, tokens[1], 0);

                        Inc(losses, tokens[1]);
                        Inc(losses, tokens[0], 0);

                        Inc(draws, tokens[0], 0);
                        Inc(draws, tokens[1], 0);

                        Inc(points, tokens[0], 3);
                        Inc(points, tokens[1], 0);
                        break;

                    case "loss":
                        Inc(losses, tokens[0]);
                        Inc(losses, tokens[1], 0);

                        Inc(wins, tokens[1]);
                        Inc(wins, tokens[0], 0);

                        Inc(draws, tokens[0], 0);
                        Inc(draws, tokens[1], 0);

                        Inc(points, tokens[0], 0);
                        Inc(points, tokens[1], 3);
                        break;

                    case "draw":
                        Inc(draws, tokens[0]);
                        Inc(draws, tokens[1]);

                        Inc(losses, tokens[0], 0);
                        Inc(losses, tokens[1], 0);

                        Inc(wins, tokens[1], 0);
                        Inc(wins, tokens[0], 0);

                        Inc(points, tokens[0]);
                        Inc(points, tokens[1]);
                        break;
                }
            }

            string result = "Team                           | MP |  W |  D |  L |  P\n";
            foreach (string team in points.Keys.OrderByDescending(t => points[t]))
            {
                int mp = wins[team] + losses[team] + draws[team];
                string l = string.Format("{0}{1}|  {2} |  {3} |  {4} |  {5} |  {6}\n",
                    team, new string(' ', 31 - team.Length),
                    mp, wins[team], draws[team], losses[team], points[team]);
                result += l;
            }
            outStream.Write(Encoding.UTF8.GetBytes(result), 0, result.Length);
        }

        static void Inc(Dictionary<string, int> dict, string val, int amount = 1)
        {
            if (dict.ContainsKey(val))
            {
                dict[val] += amount;
            }
            else
            {
                dict[val] = amount;
            }
        }
    }
}