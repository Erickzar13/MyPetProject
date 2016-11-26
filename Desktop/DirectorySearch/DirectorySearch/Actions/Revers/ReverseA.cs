using System.IO;
using System.Linq;

using DirectorySearch.Interfaces;

namespace DirectorySearch.Actions.Revers
{
    internal class ReverseA : IReverseAction
    {
        public void PerformReversse(ref string value)
        {
            string[] segments = value
                .Split(Path.DirectorySeparatorChar)
                .Reverse()
                .ToArray();

            value = string.Join(Path.DirectorySeparatorChar.ToString(), segments);
        }
    }
}
