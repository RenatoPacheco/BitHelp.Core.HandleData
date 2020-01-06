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
            IDictionary<string, int> referencia = new Dictionary<string, int>();
            referencia.Add("M", 1000);
            referencia.Add("CM", 900);
            referencia.Add("D", 500);
            referencia.Add("CD", 400);
            referencia.Add("C", 100);
            referencia.Add("XC", 90);
            referencia.Add("L", 50);
            referencia.Add("XL", 40);
            referencia.Add("X", 10);
            referencia.Add("IX", 9);
            referencia.Add("V", 5);
            referencia.Add("IV", 4);
            referencia.Add("I", 1);
            Regex regra = new Regex(@"M|CM|D|CD|C|XC|L|XL|X|IX|V|IV|I", RegexOptions.IgnoreCase);
            MatchCollection valores = regra.Matches(roman);
            if (valores.Count > 0)
            {
                int[] vakores = valores.Cast<Match>().Select(m => referencia[m.Value.ToUpper()]).ToArray();
                foreach (int item in vakores)
                    total += item;
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
