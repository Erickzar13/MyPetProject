using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.SomeMethod();

#if DEBUG
            Console.ReadKey();
#endif
        }

    }
}
