using NUnit.Framework;

namespace ExercismCSharp.csharp.trinary
{
    [TestFixture]
    public class TrinaryTest
    {
        // change Ignore to false to run test case or just remove 'Ignore = false'
        [TestCase("1", Result = 1)]
        [TestCase("2", Result = 2, Ignore = false)]
        [TestCase("10", Result = 3, Ignore = false)]
        [TestCase("11", Result = 4, Ignore = false)]
        [TestCase("100", Result = 9, Ignore = false)]
        [TestCase("112", Result = 14, Ignore = false)]
        [TestCase("222", Result = 26, Ignore = false)]
        [TestCase("1122000120", Result = 32091, Ignore = false)]
        public int Trinary_converts_to_decimal(string value)
        {
            return new Trinary(value).ToDecimal();
        }

        [TestCase("carrot", Ignore = false)]
        [TestCase("3", Ignore = false)]
        [TestCase("6", Ignore = false)]
        [TestCase("9", Ignore = false)]
        [TestCase("124578", Ignore = false)]
        [TestCase("abc1z", Ignore = false)]
        public void Invalid_trinary_is_decimal_0(string invalidValue)
        {
            Assert.That(new Trinary(invalidValue).ToDecimal(), Is.EqualTo(0));
        }

        [Test]
        public void Trinary_can_convert_formatted_strings()
        {
            Assert.That(new Trinary("011").ToDecimal(), Is.EqualTo(4));
        }
    }
}