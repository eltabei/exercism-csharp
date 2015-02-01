using System;

namespace ExercismCSharp.csharp.binary
{
    public class Binary
    {
        private readonly string binary;

        public Binary(string binary)
        {
            this.binary = binary;
        }

        public int ToDecimal()
        {
            int dec = 0;
            
            for (int i = 0; i < binary.Length; i++)
            {
                char d = binary[binary.Length - i - 1];
                if (d != '0' && d != '1')
                {
                    return 0;
                }
                if (d == '1')
                {
                    dec += (int)Math.Pow(2, i);
                }
            }
            return dec;
        }
    }
}