using Typographer;

namespace TestsForTypographer
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string enterString = "Hello             World!";
            string expected = "Hello World!";

            string actual = RulesOfTypographer.RemovingExtraSpaces(enterString);

            Assert.Equal(expected, actual);
        }
    }
}