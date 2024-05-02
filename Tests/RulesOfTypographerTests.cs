using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tests
{
    internal class RulesOfTypographerTests
    {
        [TestMethod]
        public void TestForRemovingExtraSpaces()
        {
            string enterString = "Hello             World!";
            string expected = "Hello World!";

            string actual = RulesOfTypographer.RemovingExtraSpaces(enterString);

            Assert.Equal(expected, actual);
        }
    }
}
