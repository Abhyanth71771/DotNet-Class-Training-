using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Day1_A2
    {
        static void Main()
        {
            int control, x, y;
            Boolean br = true;
            Console.WriteLine("Enter Value of Number 1");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Number 2");
            y = int.Parse(Console.ReadLine());
            do
            {

                Console.WriteLine("Options");
                Console.WriteLine("Enter 1 for Addition");
                Console.WriteLine("Enter 2 for Subtraction");
                Console.WriteLine("Enter 3 for Multiplication");
                Console.WriteLine("Enter 4 for Divide");
                Console.WriteLine("Enter 0 to quit");
                Console.WriteLine("Now Shut up and Enter Your Choice");
                control = int.Parse(Console.ReadLine());

                switch (control)
                {
                    case 0:
                        br = false;
                        break;
                    case 1:
                        Console.WriteLine("The Sum of {0} and {1} is = {2}", x, y, (add(x, y)));
                        break;
                    case 2:
                        Console.WriteLine("The Difference of {0} and {1} is = {2}", x, y, (subtract(x,y)));
                        break;
                    case 3:
                        Console.WriteLine("The Multiplication of {0} and {1} is = {2}", x, y, (multiply(x,y)));
                        break;
                    case 4:
                        Console.WriteLine("The result of  division operation{0} and {1} is = {2}", x, y, (divide(x,y)));
                        break;
                    default:
                        Console.WriteLine("Please for the love of god enter the right value");
                        ; break;
                }
            }
            while (br);
            


        }
        static int add(int x, int y)
        {
            return x + y;
        }
        static int subtract(int x, int y)
        {
            return x - y;

        }
        static int multiply(int x, int y)
        {
            return x * y;

        }
        static float divide(int x, int y)
        {
            return x/y;

        }

    }
}