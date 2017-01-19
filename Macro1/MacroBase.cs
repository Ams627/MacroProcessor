using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Macro1
{
    class MacroBase
    {
        static Dictionary<string, PropertyInfo> macroToPropertyMapping = new Dictionary<string, PropertyInfo>();
        static MacroBase()
        {
            var mytype = typeof(MacroProcessor);
            var properties = mytype.GetProperties();
            var attType = typeof(MacroAttribute);

            foreach (PropertyInfo prop in properties)
            {
                var macro = prop.GetCustomAttribute(attType, true) as MacroAttribute;
                if (macro != null)
                {
                    var name = macro.Macroname;
                    macroToPropertyMapping[name] = prop;
                }
            }
        }

        public void ExpandMacros(string input)
        {
            string pattern = @"\$\$\(([A-Z]+)\)";
            var matches = Regex.Matches(input, pattern);
            var outputString = "";
            var currentIndex = 0;

            foreach (Match match in matches)
            {
                outputString += input.Substring(currentIndex, match.Index - currentIndex);
                currentIndex = match.Index + match.Length;

                if (match.Groups.Count > 1)
                {
                    var macroname = match.Groups[1].Value;
                    PropertyInfo propertyInfo;
                    if (macroToPropertyMapping.TryGetValue(macroname, out propertyInfo))
                    {

                    }
                }
            }
            var lastIndex = matches[matches.Count - 1].Index + matches
        }
    }
}
