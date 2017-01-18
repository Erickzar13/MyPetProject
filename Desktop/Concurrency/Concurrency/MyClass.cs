using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrency
{
    internal class MyClass
    {
        public async void SomeMethod()
        {
            int a = await MyMet();

            Console.WriteLine(a.ToString());
        }

        async Task<int> MyMet()
        {
            return 5;
        }
    }
}
