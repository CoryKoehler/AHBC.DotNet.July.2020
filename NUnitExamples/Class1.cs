using NUnit.Framework;

namespace NUnitExamples
{
    public class Class1
    {
        [Test]
        public void OneEqualsOne()
        {
            //Arrange
            int actual;
            var expected = 1;
            //Act
            actual = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}