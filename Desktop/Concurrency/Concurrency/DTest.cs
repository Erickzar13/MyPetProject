using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency
{
    class DTest
    {
        private delegate string Mydelegate(string strParam);

        private static Mydelegate nrrrMydelegate = new Mydelegate(testMethod);

        private static string result = nrrrMydelegate("ddf");




        private static string testMethod(string strParam)
        {
            return strParam;
        }

        public EventHandler MyEvent  ;


        
    }
}
