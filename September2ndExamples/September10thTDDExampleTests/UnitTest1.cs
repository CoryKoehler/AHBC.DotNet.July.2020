using System;
using Xunit;
using September10thTDDExample;
namespace September10thTDDExampleTests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ShouldReturnFizzForMultipleOfThree()
        {
            //Arrange
            var input = 3;
            var expectedResult = "Fizz";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            string result = fizzBuzz.Generate(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ShouldReturnBuzzForMultiplesOfFive()
        {
            //Arrange
            var input = 5;
            var expectedResult = "Buzz";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            string result = fizzBuzz.Generate(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
