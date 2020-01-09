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
            
            IDictionary<string, int> referencia = new Dictionary<string, int>
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
            Regex regra = new Regex(@"M|CM|D|CD|C|XC|L|XL|X|IX|V|IV|I|N", RegexOptions.IgnoreCase);
            MatchCollection valores = regra.Matches(roman);

            if(valores.Count == 0 || roman.Length != string.Join("", valores).Length)
                throw new System.ArgumentException($"{roman} is invalid", nameof(roman));

            int last = 4000;
            int[] vakores = valores.Cast<Match>().Select(m => referencia[m.Value.ToUpper()]).ToArray();
            foreach (int item in vakores)
            {
                total += item;
                if (total >= 4000 || last < item || (last/5+item) == last)
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
