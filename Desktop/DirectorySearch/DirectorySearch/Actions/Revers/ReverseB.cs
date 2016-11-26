using System.IO;
using System.Linq;

using DirectorySearch.Interfaces;

namespace DirectorySearch.Actions.Revers
{
    internal class ReverseB : IReverseAction
    {
        public void PerformReversse(ref string value)
        {
            string[] segments = value
                .Split(Path.DirectorySeparatorChar)
                .Reverse()
                .Select(i => new string(i.Reverse().ToArray()))
                .ToArray();

            value = string.Join(Path.DirectorySeparatorChar.ToString(), segments);
        }
    }
}
