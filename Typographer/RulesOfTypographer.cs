using System.Text.RegularExpressions;

namespace Typographer
{
    /// <summary>
    /// Класс, содержащий правила типографи.
    /// </summary>
    public static class RulesOfTypographer
    {
        /// <summary>
        /// Метод, который удаляет лишние пробелы.
        /// </summary>
        /// <param name="text"> Исходный текст. </param>
        /// <returns> Исправленный текст. </returns>
        public static string RemovingExtraSpaces(string text)
        {
            Regex spacesRegex = new Regex(@"\s+");
            return spacesRegex.Replace(text, " ");
        }

        /// <summary>
        /// Метод, который редактирует написание дефиса.
        /// </summary>
        /// <param name="text"> Исходный текст. </param>
        /// <returns> Исправленный текст. </returns>
        public static string EditingHyphen(string text)
        {
            Regex hyphenRegex = new Regex(@"\s+-\s+");
            return hyphenRegex.Replace(text, "-");
        }

        /// <summary>
        /// Метод, который редактирует написание многоточия.
        /// </summary>
        /// <param name="text"> Исходный текст. </param>
        /// <returns> Исправленный текст. </returns>
        public static string EditingEllipsis(string text)
        {
            Regex ellipsesRegex = new Regex(@"\.\.\.");
            return ellipsesRegex.Replace(text, "\u2026");
        }

        /// <summary>
        /// Метод, который редактирует написание кавычек.
        /// </summary>
        /// <param name="text"> Исходный текст. </param>
        /// <returns> Исправленный текст. </returns>
        public static string EditingQuotes(string text)
        {
            Regex quotesRegex = new Regex("\"(.*?)\"");
            return quotesRegex.Replace(text, "«$1»");
        }

        /// <summary>
        /// Метод, который редактирует написание знаков препинания, дефиса, скобоки и кавычек.
        /// </summary>
        /// <param name="text"> Исходный текст. </param>
        /// <returns> Исправленный текст. </returns>
        public static string EditingPunctuationMarks(string text)
        {
            Regex pointRegex = new Regex(@"\s*\.\s*");
            Regex comaRegex = new Regex(@"\s*\,\s*");
            Regex questionMarkRegex = new Regex(@"\s*\?\s*");
            Regex exclamationMarkRegex = new Regex(@"\s*\!\s*");
            Regex dashRegex = new Regex(@"\s*\u2013\s*");
            Regex bracketsRegex = new Regex(@"\(\s+(.*?)\s+\)");
            Regex quotesRegex = new Regex("\"\\s+(.*?)\\s+\"");

            text = pointRegex.Replace(text, ". ");
            text = comaRegex.Replace(text, ", ");
            text = questionMarkRegex.Replace(text, "? ");
            text = exclamationMarkRegex.Replace(text, "! ");
            text = dashRegex.Replace(text, " \u2013 ");
            text = bracketsRegex.Replace(text, "($1)");
            text = quotesRegex.Replace(text, "\"$1\"");

            return text;
        }

        /// <summary>
        /// Метод, который заменяет скобки на смайлики.
        /// </summary>
        /// <param name="text"> Исходный текст. </param>
        /// <returns> Исправленный текст. </returns>
        public static string ChangingBracketToSmiley(string text)
        {
            Regex smileyRegex = new Regex(@"\((.*?)\)");
            return smileyRegex.Replace(text, ":( $1 :)");
        }

        /// <summary>
        /// Метод, который заменяет все буквы "С" на "С#".
        /// </summary>
        /// <param name="text"> Исходный текст. </param>
        /// <returns> Отредактированый текст. </returns>
        public static string ChangingSpellingLetter_C(string text)
        {
            Regex letter_C_Regex = new Regex("(\u0421|\u0043)");
            return letter_C_Regex.Replace(text, "C#");
        }   
    }
}