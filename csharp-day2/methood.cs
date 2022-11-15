using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_day2
{
    internal class methood
    {
        static void Main()
        {
            int x, y;
            Console.WriteLine("Enter the first number:");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            y = int.Parse(Console.ReadLine());
            subtract(x, y);
        }
        static void add(int x, int y)
        {
            Console.WriteLine("The result of {0} + {1} is eqial to {2}", x, y, (x + y));
        }
        static void subtract(int x, int y)
        {
            Console.WriteLine("The result of {0} - {1} is equal to {2}", x, y, (x - y));
        }
        
    }
}
