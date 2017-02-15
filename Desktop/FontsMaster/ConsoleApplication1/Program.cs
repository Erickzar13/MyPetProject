using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Xml;
using System.Xml.Serialization;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ToXML(Fonts.SystemFontFamilies.ToList());

            List<FontFamily> test = FromXML();
        }

        public static List<FontFamily> FromXML()
        {
            var test= File.ReadAllLines(@"..\Fonts.xml").ToList();

            return test.Select(s => new FontFamily(s)).ToList();
        }

        public static void ToXML(List<FontFamily> fontFamilies)
        {
            List<string> fontNames = fontFamilies.Select(family => family.ToString()).ToList();
          
            File.WriteAllLines(@"..\Fonts.xml", fontNames);
        }
    }
}
