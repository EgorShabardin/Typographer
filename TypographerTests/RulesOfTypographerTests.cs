namespace Typographer.Tests
{
    [TestClass()]
    public class RulesOfTypographerTests
    {
        [TestMethod()]
        public void RemovingExtraSpacesTest()
        {
            string inputString = "Hello               World!";
            string expected = "Hello World!";

            string actual = RulesOfTypographer.RemovingExtraSpaces(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EditingHyphenTest()
        {
            string inputString = "Кровать - диван";
            string expected = "Кровать-диван";

            string actual = RulesOfTypographer.EditingHyphen(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EditingEllipsisTest()
        {
            string inputString = "Слово ...";
            string expected = "Слово \u2026";

            string actual = RulesOfTypographer.EditingEllipsis(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EditingQuotesTest()
        {
            string inputString = "\"Слово\"";
            string expected = "«Слово»";

            string actual = RulesOfTypographer.EditingQuotes(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EditingPunctuationMarksPointTest()
        {
            string inputString = "Слово       .        Слово";
            string expected = "Слово. Слово";

            string actual = RulesOfTypographer.EditingPunctuationMarks(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EditingPunctuationMarksComaTest()
        {
            string inputString = "Слово       ,        cлово";
            string expected = "Слово, cлово";

            string actual = RulesOfTypographer.EditingPunctuationMarks(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EditingPunctuationMarksQuestionMarkTest()
        {
            string inputString = "Слово       ?        Слово";
            string expected = "Слово? Слово";

            string actual = RulesOfTypographer.EditingPunctuationMarks(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EditingPunctuationMarksExclamationMarkTest()
        {
            string inputString = "Слово       !        Слово";
            string expected = "Слово! Слово";

            string actual = RulesOfTypographer.EditingPunctuationMarks(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EditingPunctuationMarksDashTest()
        {
            string inputString = "Слово       \u2013        слово";
            string expected = "Слово \u2013 слово";

            string actual = RulesOfTypographer.EditingPunctuationMarks(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EditingPunctuationMarksBracketsTest()
        {
            string inputString = "(     Слово     )";
            string expected = "(Слово)";

            string actual = RulesOfTypographer.EditingPunctuationMarks(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EditingPunctuationMarksQuotesTest()
        {
            string inputString = "\"     Слово     \"";
            string expected = "\"Слово\"";

            string actual = RulesOfTypographer.EditingPunctuationMarks(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ChangingBracketToSmileyTest()
        {
            string inputString = "(Смайлик)";
            string expected = ":( Смайлик :)";

            string actual = RulesOfTypographer.ChangingBracketToSmiley(inputString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ChangingSpellingLetter_CTest()
        {
            string inputString = "Слово City";
            string expected = "C#лово C#ity";

            string actual = RulesOfTypographer.ChangingSpellingLetter_C(inputString);

            Assert.AreEqual(expected, actual);
        }
    }
}