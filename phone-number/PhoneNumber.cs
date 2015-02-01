namespace ExercismCSharp.phone_number
{
    class PhoneNumber
    {
        private readonly char[] chars = new char[] { ' ', '-', '.', '(', ')'};
        private const string BadNumber = "0000000000";

        public string Number { get; private set; }

        public string AreaCode
        {
            get { return Number.Substring(0, 3); }
        }

        public PhoneNumber(string s)
        {
            string s2 = s;
            foreach (char c in chars)
            {
                s2 = s2.Replace(c.ToString(), "");
            }

            if (s2.Length == 10)
            {
                Number = s2;
            }
            else if (s2.Length == 11 && s2.StartsWith("1"))
            {
                Number = s2.Substring(1, 10);
            }
            else
            {
                Number = BadNumber;
            }
        }

        public override string ToString()
        {
            return string.Format("({0}) {1}-{2}", Number.Substring(0, 3), Number.Substring(3, 3), Number.Substring(6, 4));
        }
    }
}
