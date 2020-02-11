using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BitHelp.Core.HandleData
{
    public static class NumberHandle
    {
        public static int RomanToInt(string roman)
        {
            int total = 0;

            IDictionary<string, int> reference = new Dictionary<string, int>
            {
                { "M", 1000 },
                { "CM", 900 },
                { "D", 500 },
                { "CD", 400 },
                { "C", 100 },
                { "XC", 90 },
                { "L", 50 },
                { "XL", 40 },
                { "X", 10 },
                { "IX", 9 },
                { "V", 5 },
                { "IV", 4 },
                { "I", 1 },
                { "N", 0 }
            };
            Regex regex = new Regex(@"M|CM|D|CD|C|XC|L|XL|X|IX|V|IV|I|N", RegexOptions.IgnoreCase);
            IEnumerable<string> values = regex.Matches(roman)
                .Cast<Match>().Select(m => m.Value).ToArray();

            if (values.Count() == 0 || roman.Length != string.Join("", values).Length)
                throw new System.ArgumentException($"{roman} is invalid", nameof(roman));

            int last = 4000;
            int[] indexes = values.Select(m => reference[m.ToUpper()]).ToArray();
            foreach (int item in indexes)
            {
                total += item;
                if (total >= 4000 || last < item || (last / 5 + item) == last)
                    throw new System.ArgumentException($"{roman} is invalid", nameof(roman));

                last = item;
            }

            return total;
        }

        public static int Factorial(int value)
        {
            if (value <= 1)
                return 1;
            else return value * Factorial(value - 1);
        }
    }
}
