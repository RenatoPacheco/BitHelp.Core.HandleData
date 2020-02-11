using System.Text;
using System.Text.RegularExpressions;

namespace BitHelp.Core.HandleData
{
    public static class TextHandle
    {
        public static string BreakText(string value, int limit)
        {
            value = value?.Trim();
            return object.Equals(value, null) || value.Length <= limit
                ? value : $"{value.Substring(0, limit)}...";
        }

        public static string ProperName(string value)
        {
            StringBuilder result = new StringBuilder();
            string[] list;

            value = Regex.Replace(value, @"[\s ]+", " ", RegexOptions.IgnoreCase).Trim().ToLower();
            if (value == string.Empty)
                return value;

            list = value.Split(' ');

            foreach (string item in list)
            {
                if (!Regex.IsMatch(item, "^(da|de|do|das|dos)$", RegexOptions.IgnoreCase))
                    result.Append(" " + item[0].ToString().ToUpper() + item.Substring(1));
                else
                    result.Append(" " + item);
            }

            return result.ToString().Trim();
        }

        public static string RemoveSpecialCharacters(string value)
        {
            value = value?.Trim();
            if (!object.Equals(value, null))
            {
                value = Regex.Replace(value, @"[áàäâã]", "a");
                value = Regex.Replace(value, @"[ÁÀÄÂÃ]", "A");
                value = Regex.Replace(value, @"[éèëê]", "e");
                value = Regex.Replace(value, @"[ÉÈËÊ]", "E");
                value = Regex.Replace(value, @"[íìïî]", "i");
                value = Regex.Replace(value, @"[ÍÌÏÎ]", "I");
                value = Regex.Replace(value, @"[óòöôõ]", "o");
                value = Regex.Replace(value, @"[ÓÒÖÔÕ]", "O");
                value = Regex.Replace(value, @"[úùüû]", "u");
                value = Regex.Replace(value, @"[ÚÙÜÛ]", "U");
                value = Regex.Replace(value, @"[ç]", "c");
                value = Regex.Replace(value, @"[Ç]", "C");
                value = Regex.Replace(value, @"[ñ]", "n");
                value = Regex.Replace(value, @"[Ñ]", "N");
                value = Regex.Replace(value, @" ?[`´~^¨]+ ?", " ");
            }
            return value;
        }

        public static string ToUri(string value, string delemiter = "-")
        {
            if (delemiter is null)
            {
                throw new System.ArgumentNullException(nameof(delemiter));
            }

            value = RemoveSpecialCharacters(value);
            if (!string.IsNullOrWhiteSpace(value))
            {
                value = Regex.Replace(value, @"[^0-9a-zA-Z\-_ ]", " ");
                value = Regex.Replace(value, @"[ ]+", delemiter);
            }
            return value;
        }
    }
}
