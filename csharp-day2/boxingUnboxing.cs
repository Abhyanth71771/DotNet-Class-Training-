using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_day2
{
    internal class boxingUnboxing
    {
        static void Main()
        {

            //boxing
            int x1 = 10;
            object o = x1;
            //unboxing
            int y = (int)o;
            //boxing
            print(32);
            print("hello how are you");
            Console.WriteLine(o);
            print(24);
            static void print(object o)
            {
                Console.WriteLine(o);
            }

        }
    }
}
