using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macro1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var m = new MacroProcessor();
                m.ExpandMacros("Hello s$$(WONK)aid the man to the $$(WINK)small dog.");
            }
            catch (Exception ex)
            {
                var actualType = ex.GetType().Name;
                string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                string progname = Path.GetFileNameWithoutExtension(codeBase);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }
        }
    }
}
