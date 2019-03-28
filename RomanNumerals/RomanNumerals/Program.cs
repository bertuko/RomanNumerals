using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var result in MainInternal(args))
            {
                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// Internal function to process the arguments
        /// </summary>
        /// <param name="args">command line arguments</param>
        /// <returns>The strings to display in the console</returns>
        private static IEnumerable<string> MainInternal(IEnumerable<string> args)
        {
            foreach (var arg in args)
            {
                // if the argument is not an integer or greater than 3999, we skip it
                // if the number is zero or negative, too
                if (!int.TryParse(arg, out int number) || number <= 0 || number > 3999)
                    continue;
                
                yield return FormatLine(arg, number.GetRomanNumber());
            }
        }

        /// <summary>
        /// Formats the line to the format specified in the exercise
        /// </summary>
        /// <param name="number">number in arabic numerals</param>
        /// <param name="romanNumber">number in roman numerals</param>
        /// <returns>The formatted string to print</returns>
        private static string FormatLine(string number, string romanNumber)
        {
            // return the line to display in the specified format
            return $"{number} = \"{romanNumber}\"";
        }

    }
}