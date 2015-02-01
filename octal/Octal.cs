namespace ExercismCSharp.csharp.octal
{
    public class Octal
    {
        private readonly string octal;
        private const string AllowedChars = "01234567";

        public Octal(string value)
        {
            octal = value;
        }

        public int ToDecimal()
        {
            int dec = 0;
            int p = 1;
            for (int i = 0; i < octal.Length; i++)
            {
                string d = octal[octal.Length - i - 1].ToString();
                if (!AllowedChars.Contains(d))
                {
                    return 0;
                }
                if (d != "0")
                {
                    dec += int.Parse(d) * p;
                }
                p *= 8;
            }
            return dec;
        }
    }
}