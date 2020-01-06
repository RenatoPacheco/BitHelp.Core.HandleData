using System.Text;
using System.Text.RegularExpressions;

namespace BitHelp.Core.HandleData
{
    public static class TextHandle
    {
        public static string BreakText(string value, int limit)
        {
            return object.Equals(value, null) || value.Length <= limit
                ? value : string.Format("{0}...", value.Substring(0, limit));
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
            value = value.Trim();
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
            value = Regex.Replace(value, @"[^0-9a-z ]", " ");
            value = Regex.Replace(value, @"[\ ]+", "-");
            return value;
        }

        public static string HtmlEncode(string value)
        {
            value = Regex.Replace(value, @"á", "&aacute;");
            value = Regex.Replace(value, @"Á", "&Aacute;");
            value = Regex.Replace(value, @"é", "&eacute;");
            value = Regex.Replace(value, @"É", "&Eacute;");
            value = Regex.Replace(value, @"í", "&iacute;");
            value = Regex.Replace(value, @"Í", "&Iacute;");
            value = Regex.Replace(value, @"ó", "&oacute;");
            value = Regex.Replace(value, @"Ó", "&Oacute;");
            value = Regex.Replace(value, @"ú", "&uacute;");
            value = Regex.Replace(value, @"Ú", "&Uacute;");
            // ------------------------------------------
            value = Regex.Replace(value, @"à", "&agrave;");
            value = Regex.Replace(value, @"À", "&Agrave;");
            value = Regex.Replace(value, @"è", "&egrave;");
            value = Regex.Replace(value, @"È", "&Egrave;");
            value = Regex.Replace(value, @"ì", "&igrave;");
            value = Regex.Replace(value, @"Ì", "&Igrave;");
            value = Regex.Replace(value, @"ò", "&ograve;");
            value = Regex.Replace(value, @"Ò", "&Ograve;");
            value = Regex.Replace(value, @"ù", "&ugrave;");
            value = Regex.Replace(value, @"Ù", "&Ugrave;");
            // ------------------------------------------
            value = Regex.Replace(value, @"â", "&acirc;");
            value = Regex.Replace(value, @"Â", "&Acirc;");
            value = Regex.Replace(value, @"ê", "&ecirc;");
            value = Regex.Replace(value, @"Ê", "&Ecirc;");
            value = Regex.Replace(value, @"î", "&icirc;");
            value = Regex.Replace(value, @"Î", "&Icirc;");
            value = Regex.Replace(value, @"ô", "&ocirc;");
            value = Regex.Replace(value, @"Ô", "&Ocirc;");
            value = Regex.Replace(value, @"û", "&ucirc;");
            value = Regex.Replace(value, @"Û", "&Ucirc;");
            // ------------------------------------------
            value = Regex.Replace(value, @"ä", "&auml;");
            value = Regex.Replace(value, @"Ä", "&Auml;");
            value = Regex.Replace(value, @"ë", "&euml;");
            value = Regex.Replace(value, @"Ë", "&Euml;");
            value = Regex.Replace(value, @"ï", "&iuml;");
            value = Regex.Replace(value, @"Ï", "&Iuml;");
            value = Regex.Replace(value, @"ö", "&ouml;");
            value = Regex.Replace(value, @"Ö", "&Ouml;");
            value = Regex.Replace(value, @"ü", "&uuml;");
            value = Regex.Replace(value, @"Ü", "&Uuml;");
            // ------------------------------------------
            value = Regex.Replace(value, @"ã", "&atilde;");
            value = Regex.Replace(value, @"Ã", "&Atilde;");
            value = Regex.Replace(value, @"õ", "&otilde;");
            value = Regex.Replace(value, @"Õ", "&Otilde;");
            value = Regex.Replace(value, @"ñ", "&ntilde;");
            value = Regex.Replace(value, @"Ñ", "&Ntilde;");
            // ------------------------------------------
            value = Regex.Replace(value, @"ç", "&ccedil;");
            value = Regex.Replace(value, @"Ç", "&Ccedil;");
            // ------------------------------------------
            value = Regex.Replace(value, @"ª", "&ordf;");
            value = Regex.Replace(value, @"º", "&ordm;");
            value = Regex.Replace(value, @"°", "&deg;");
            value = Regex.Replace(value, @"°", "&deg;");
            value = Regex.Replace(value, @"¿", "&iquest;");

            return value;
        }

        public static string ToUri(object value)
        {
            return ToUri(value, "-");
        }

        public static string ToUri(object value, string delemiter)
        {
            string result = value.ToString().Trim();
            result = Regex.Replace(result, @"[áàäâã]", "a");
            result = Regex.Replace(result, @"[ÀÀÄÂÃ]", "A");
            result = Regex.Replace(result, @"[éèëê]", "e");
            result = Regex.Replace(result, @"[ÉÈËÊ]", "E");
            result = Regex.Replace(result, @"[íìïî]", "i");
            result = Regex.Replace(result, @"[ÍÌÏÎ]", "I");
            result = Regex.Replace(result, @"[óòöôõ]", "o");
            result = Regex.Replace(result, @"[ÓÒÖÔÕ]", "O");
            result = Regex.Replace(result, @"[úùüû]", "u");
            result = Regex.Replace(result, @"[ÚÙÜÛ]", "U");
            result = Regex.Replace(result, @"[ç]", "c");
            result = Regex.Replace(result, @"[Ç]", "C");
            result = Regex.Replace(result, @"[ñ]", "n");
            result = Regex.Replace(result, @"[Ñ]", "N");
            result = Regex.Replace(result, @"[^0-9a-zA-Z_\- ]", " ");
            result = Regex.Replace(result, @"[\ ]+", " ");
            result = result.Trim();
            result = Regex.Replace(result, @"[\ ]+", "-");
            return result;
        }
    }
}
