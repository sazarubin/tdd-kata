using Xunit;

namespace TDDKata
{
    public class CalcTests
    {
        [Fact]
        public void AddForEmptyString_ReturnsZero()
        {
            var calc = new Calculator.Calculator();
            Assert.Equal(0, calc.Add(""));
        }
    }
}