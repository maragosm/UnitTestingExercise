using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(1, 1, 1, 3)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(10, 10, 10, 30)]
        [InlineData(100, 100, 100, 300)]
        [InlineData(-1, 6, -3, 2)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            Calculator tester = new Calculator();
            var actual = tester.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(10, 6, 4)]
        [InlineData(4, 6, -2)]
        [InlineData(15, 14, 1)]
        [InlineData(-6, -2, -4)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            Calculator tester = new Calculator();
            var actual = tester.Subtract(minuend, subtrhend);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 6, 12)]
        [InlineData(4, 4, 16)]
        [InlineData(7, 9, 63)]
        [InlineData(8, 3, 24)]
        [InlineData(-9, 2, -18)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            Calculator tester = new Calculator();
            var actual = tester.Multiply(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(9, 9, 1)]
        [InlineData(14, 7, 2)]
        [InlineData(5, 4, 1.25)]
        [InlineData(-5, -5, 1)]
        public void DivideTest(int num1, int num2, int expected)
        {
            Calculator tester = new Calculator();
            var actual = tester.Divide(num1, num2);
            Assert.Equal(expected, actual);

        }

    }
}
