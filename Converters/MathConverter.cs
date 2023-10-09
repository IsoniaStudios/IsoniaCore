using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using Avalonia.Data.Converters;

namespace IsoniaCore.Converters
{
    // Does a math equation on the bound value.
    // Use @VALUE in your mathEquation as a substitute for bound value
    // Operator order is parenthesis first, then Left-To-Right (no operator precedence)
    public sealed class MathConverter : IValueConverter
    {
        private static readonly string[] grouping = new[] { "(", ")" };
        private static readonly string[] operators = new[] { "+", "-", "*", "/", "%" };
        private static readonly char[] allOperators = new[] { '+', '-', '*', '/', '%', '(', ')' };

        #region IValueConverter Members
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            // Parameter validation and parsing
            if (value is null || parameter is null || parameter is not string || parameter is not string mathEquation)
                return value;

            // Parse value into equation and remove spaces
            mathEquation = mathEquation.Replace(" ", "")
                                       .Replace("@VALUE", value.ToString());

            // Validate values and get list of numbers in equation
            List<double> numbers = new();

            foreach (string s in mathEquation.Split(allOperators))
            {
                if (s == string.Empty)
                    continue;

                if (double.TryParse(s, out double tmp))
                {
                    numbers.Add(tmp);
                }
                else
                {
                    // Handle Error - Some non-numeric, operator, or grouping character found in string
                    throw new InvalidCastException();
                }
            }

            // Begin parsing method
            EvaluateMathString(ref mathEquation, ref numbers, 0);

            // After parsing the numbers list should only have one value - the total
            return numbers[0];
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion

        /// <summary>
        /// Evaluates a mathematical string and keeps track of the results in a List<double> of numbers
        /// </summary>
        /// <param name="mathEquation"></param>
        /// <param name="numbers"></param>
        /// <param name="index"></param>
        /// <exception cref="FormatException"></exception>
        private void EvaluateMathString(ref string mathEquation, ref List<double> numbers, int index)
        {
            // Loop through each mathemtaical token in the equation
            string token = GetNextToken(mathEquation);

            while (token != string.Empty)
            {
                // Remove token from mathEquation
                mathEquation = mathEquation.Remove(0, token.Length);

                // If token is a grouping character, it affects program flow
                if (grouping.Contains(token))
                {
                    switch (token)
                    {
                        case "(":
                            EvaluateMathString(ref mathEquation, ref numbers, index);
                            break;
                        case ")":
                            return;
                    }
                }

                // If token is an operator, do requested operation
                if (operators.Contains(token))
                {
                    // If next token after operator is a parenthesis, call method recursively
                    string nextToken = GetNextToken(mathEquation);
                    if (nextToken == "(")
                    {
                        EvaluateMathString(ref mathEquation, ref numbers, index + 1);
                    }

                    // Verify that enough numbers exist in the List<double> to complete the operation
                    // and that the next token is either the number expected, or it was a ( meaning
                    // that this was called recursively and that the number changed
                    if (numbers.Count > (index + 1) && (double.Parse(nextToken) == numbers[index + 1] || nextToken == "("))
                    {
                        switch (token)
                        {
                            case "+":
                                numbers[index] = numbers[index] + numbers[index + 1];
                                break;
                            case "-":
                                numbers[index] = numbers[index] - numbers[index + 1];
                                break;
                            case "*":
                                numbers[index] = numbers[index] * numbers[index + 1];
                                break;
                            case "/":
                                numbers[index] = numbers[index] / numbers[index + 1];
                                break;
                            case "%":
                                numbers[index] = numbers[index] % numbers[index + 1];
                                break;
                        }
                        numbers.RemoveAt(index + 1);
                    }
                    else
                    {
                        // Handle Error - Next token is not the expected number
                        throw new FormatException("Next token is not the expected number");
                    }
                }

                token = GetNextToken(mathEquation);
            }
        }

        /// <summary>
        /// Gets the next mathematical token in the equation
        /// </summary>
        /// <param name="mathEquation"></param>
        /// <returns></returns>
        private static string GetNextToken(string mathEquation)
        {
            // If we're at the end of the equation, return string.empty
            if (mathEquation == string.Empty)
            {
                return string.Empty;
            }

            // Get next operator or numeric value in equation and return it
            string tmp = "";
            foreach (char c in mathEquation)
            {
                if (allOperators.Contains(c))
                {
                    return tmp == "" ? c.ToString() : tmp;
                }
                else
                {
                    tmp += c;
                }
            }

            return tmp;
        }
    }
}