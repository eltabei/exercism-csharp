using System.Linq;

namespace ExercismCSharp.bob
{
    class Bob
    {
        public string Hey(string phrase)
        {
            if (string.IsNullOrWhiteSpace(phrase))
            {
                return "Fine. Be that way!";
            }
            if (!IsNumeric(phrase) && phrase.ToUpper() == phrase)
            {
                return "Whoa, chill out!";
            }
            if (phrase.EndsWith("?"))
            {
                return "Sure.";
            }
            return "Whatever.";
        }

        static bool IsNumeric(string s)
        {
            return s.All(c => !char.IsLetter(c));
        }
    }
}
