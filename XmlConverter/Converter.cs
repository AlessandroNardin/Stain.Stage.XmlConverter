using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace ParserXml
{
    public static class Converter {
        private static char val;

        public static void Compare()
        {
            int i = 0;
            bool finiti = false;
            using (var reader = new StreamReader(@"C:\Users\utente.elettrico.STAIN\Desktop\WBS-Structure-Only.xml"))
            {
                using (var writer = new StreamWriter(@"C:\Users\utente.elettrico.STAIN\Desktop\new.txt", true)) {
                    while (!finiti)
                    {
                        var integ = (char)reader.Read();
                        if (integ == -1) {
                            finiti = true;
                        }
                        val = (char)integ;
                        if (!XmlConvert.IsXmlChar(val))
                        {
                            var tempvar = $"U+{val.ToString()}";
                            writer.Write(tempvar);
                        }
                        else
                        {
                            writer.Write(val);
                        }
                    }
                }
            }

        }
        public static void GetConvertedText()
        {   
            Compare();
            //Console.WriteLine($"Interrotto al carattere numero: {i}");
        }
    }
}
