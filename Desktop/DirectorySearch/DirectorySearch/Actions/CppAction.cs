using System.IO;

using DirectorySearch.Prototypes;

namespace DirectorySearch.Actions
{
    internal class CppAction : FileAction
    {
        public CppAction()
            : base("*.cpp")
        {
        }

        public override string Search(DirectoryInfo directory, FileInfo file)
        {
            string result = file.FullName
                                .Replace(directory.FullName, string.Empty)
                                .TrimStart(Path.DirectorySeparatorChar) + " /";

            return result;
        }
    }
}
