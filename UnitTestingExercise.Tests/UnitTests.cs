using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 3, 3, 9)]
        [InlineData(6, 6, 6, 18)]
        [InlineData(9, 9, 9, 27)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 3, 7)]
        [InlineData(9, 2, 7)]
        [InlineData(8, 1, 7)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 9)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(6, 2, 3)]
        [InlineData(3, 1, 3)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add2()
        {
            //Arrange
            var num1 = 3;
            var num2 = 2;
            var expected = 5;

            //Act
            var actual = UnitTestMethods.Add2(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract2()
        {
            //Arrange
            var num1 = 6;
            var num2 = 2;
            var expected = 4;

            //Act
            var actual = UnitTestMethods.Subtract2(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
