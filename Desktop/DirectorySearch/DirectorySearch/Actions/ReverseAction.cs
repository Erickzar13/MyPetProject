using System.IO;

using DirectorySearch.Actions.Revers;
using DirectorySearch.Interfaces;
using DirectorySearch.Prototypes;

namespace DirectorySearch.Actions
{
    internal class ReverseAction : FileAction
    {
        private readonly IReverseAction strategy;

        public ReverseAction(bool reverse): base("*")
        {
            if (reverse)
                strategy = new ReverseA();
            else
                strategy = new ReverseB();
        }

        public override string Search(DirectoryInfo directory, FileInfo file)
        {
            string result = file.FullName
                                .Replace(directory.FullName, string.Empty)
                                .TrimStart(Path.DirectorySeparatorChar);

            strategy.PerformReversse(ref result);

            return result;
        }
    }
}
