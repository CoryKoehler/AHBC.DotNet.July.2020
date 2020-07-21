using NUnit.Framework;

namespace July20thTestingExamples
{
    public class Class1
    {
        [Test]
        public void OneEqualsOne()
        {
            var expected = 1;
            var actual = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
