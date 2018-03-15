using System;
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

        [Fact]
        public void AddForTwoNumbers_ReturnsTheirSum()
        {
            var calc = new Calc();
            Assert.Equal(36, calc.Add("11,25"));
        }

        [Fact]
        public void AddForUnknownAmountOfNumbers_ReturnsTheirSum()
        {
            var calc = new Calc(); 
            Assert.Equal(6, calc.Add("1,2,3"));
        }

        [Fact]
        public void AddWithLineBreak_ReturnsSum()
        {
            var calc = new Calc();
            Assert.Equal(6, calc.Add("1,2\n3"));
        }
        
        [Fact]
        public void AddWithLineBreakAndComma_Throws()
        {
            var calc = new Calc();
            Assert.ThrowsAny<Exception>(() => calc.Add("1,2,\n3"));
        }
    }
}