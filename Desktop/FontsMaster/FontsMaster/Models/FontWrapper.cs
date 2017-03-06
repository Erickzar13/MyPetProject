using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Media;

namespace FontsMaster.Models
{
    public class FontWrapper
    {
        public static List<FontFamily> FromXML()
        {
            var test = File.ReadAllLines(@"..\Fonts.xml").ToList();

            return test.Select(s => new FontFamily(s)).ToList();
        }

        public static void ToXML(IEnumerable<FontFamily> fontFamilies)
        {
            List<string> fontNames = fontFamilies.Select(family => family.ToString()).ToList();

            File.WriteAllLines(@"..\Fonts.xml", fontNames);
        }
    }
}
