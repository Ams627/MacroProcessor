using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Macro1
{
    class MacroProcessor : MacroBase
    {
        [Macro("WONK")]
        
        public static int Wonk { get; set; } = 0;

        [Macro("WINK")]
        public static string Bonk { get; set; } = "Bonk";
    }
}
