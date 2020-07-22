using System;
using Xunit;

namespace XUnitExamples
{
    public class Class1
    {
        [Fact]
        public void OneEqualsOne()
        {
            //Arrange
            int actual;
            var expected = 1;
            //Act
            actual = 1;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
