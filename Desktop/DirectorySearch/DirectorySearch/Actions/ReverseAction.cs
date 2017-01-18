using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            List<string> resultList;
            string tmpResult;

            Directory.GetFiles(directory.FullName, SearchStrategy);

            resultList = Directory.GetFiles(directory.FullName, SearchStrategy).ToList();

           

            for (int i = 0; i < resultList.Count; i++)
            {
                tmpResult = resultList[i];

                strategy.PerformReversse(ref tmpResult);

                resultList[i] = tmpResult;
            }


            strategy.PerformReversse(ref result);

            return result;
        }
    }
}
