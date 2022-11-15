using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Day1_A3
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(Check_prime(n));
        }
        static bool Check_prime(int a)
        {
            int  i, m = 0, flag = 0;
            m = a / 2;
            for (i = 2; i <= m; i++)
            {
                if (a % i == 0)
                {
                    return false;
                    
                    break;
                }
            }
           return true;
        }
    }
}
