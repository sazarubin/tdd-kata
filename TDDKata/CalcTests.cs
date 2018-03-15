using Calculator;
using Xunit;

namespace TDDKata
{
    public class CalcTests
    {
        [Fact]
        public void AddForEmptyString_ReturnsZero()
        {
            var calc = new Calc();
            Assert.Equal(0, calc.Add(""));
        }

        [Fact]
        public void AddForZero_ReturnsZero()
        {
            var calc = new Calc();
            Assert.Equal(0, calc.Add("0"));
        }

        [Fact]
        public void AddForOneNumber_ReturnsNumberItself()
        {
            var calc = new Calc();
            Assert.Equal(1, calc.Add("1"));
        }
    }
}