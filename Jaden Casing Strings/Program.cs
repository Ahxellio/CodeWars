using System;
using System.Globalization;

namespace Jaden_Casing_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JadenCase.ToJadenCase("How can mirrors be real if our eyes aren't real");
        }
    }
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            var text = new CultureInfo("en-EN").TextInfo;
            return text.ToTitleCase(text.ToLower(phrase));
        }
    }
}