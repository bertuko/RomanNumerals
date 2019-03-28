using System.Collections.Generic;

namespace RomanNumerals
{
    public static class RomanConverter
    {
        /// <summary>
        /// Arabic - Roman numerals equivalencies from major to minor (the order matters)
        /// </summary>
        private static readonly IDictionary<int, string> Roman = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        /// <summary>
        /// Converts the number to roman numerals (used recursively)
        /// </summary>
        /// <param name="number">The number to convert</param>
        /// <returns>The number in roman numerals</returns>
        public static string GetRomanNumber(this int number)
        {
            foreach (var r in Roman)
            {
                // recursively call current function reducing the number by the amount in the dictionary
                if (number >= r.Key)
                    return r.Value + GetRomanNumber(number - r.Key);
            }
            return string.Empty;
        }
    }
}
