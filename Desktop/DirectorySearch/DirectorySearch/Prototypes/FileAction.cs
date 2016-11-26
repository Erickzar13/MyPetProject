using System.IO;

namespace DirectorySearch.Prototypes
{
    internal abstract class FileAction
    {
        public string Result { get; set; }

        protected string SearchStrategy { get; }

        protected FileAction(string searchStrategy)
        {
            SearchStrategy = searchStrategy;
        }

        public abstract string Search(DirectoryInfo directory, FileInfo file);
    }
}
