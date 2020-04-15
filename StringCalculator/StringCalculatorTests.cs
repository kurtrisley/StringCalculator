using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StringCalculator
{
    public class StringCalculatorTests
    {
        [Fact]
        public void EmptyStringReturnsZero()
        {
            var calculator = new Calculator();

            int answer = calculator.Calculate("");

            Assert.Equal(0, answer);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("22", 22)]
        public void SingleNumber(string numbers, int expected)
        {
            var calculator = new Calculator();
            int answer = calculator.Calculate(numbers);
            Assert.Equal(expected, answer);

        }

        [Fact]
        public void MultipleNumbers()
        {
            var calculator = new Calculator();
            int answer = calculator.Calculate("1,2");
            Assert.Equal(3, answer);
        }

        [Fact]
        public void UnknownNumbers()
        {
            var calculator = new Calculator();
            int answer = calculator.Calculate("1,2,3");
            Assert.Equal(6, answer);
        }
    }
}
