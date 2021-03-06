using NUnit.Framework;

namespace ExercismCSharp.csharp.hexadecimal
{
    [TestFixture]
    public class HexadecimalTest
    {
        // change Ignore to false to run test case or just remove 'Ignore = false'
        [TestCase("1", Result = 1)]
        [TestCase("c", Result = 12, Ignore = false)]
        [TestCase("10", Result = 16, Ignore = false)]
        [TestCase("af", Result = 175, Ignore = false)]
        [TestCase("100", Result = 256, Ignore = false)]
        [TestCase("19ace", Result = 105166, Ignore = false)]
        [TestCase("19ace", Result = 105166, Ignore = false)]
        public int Hexadecimal_converts_to_decimal(string hexadecimal)
        {
            return Hexadecimal.ToDecimal(hexadecimal);
        }

        [Test]
        public void Invalid_hexadecimal_is_decimal_0()
        {
            Assert.That(Hexadecimal.ToDecimal("carrot"), Is.EqualTo(0));
        }

        [TestCase("000000", Result = 0, Ignore = false)]
        [TestCase("ffffff", Result = 16777215, Ignore = false)]
        [TestCase("ffff00", Result = 16776960, Ignore = false)]
        public int Octal_can_convert_formatted_strings(string hexidecimal)
        {
            return Hexadecimal.ToDecimal(hexidecimal);
        }
    }
}