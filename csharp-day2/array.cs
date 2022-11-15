using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_day2
{
    internal class array
    {
        static void Main()
        {
            //array
            string[] names = new string[3];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter name {0}: ", i);
                names[i] = Console.ReadLine();
            }



            ////display the names
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            foreach(string name in names) {
                Console.WriteLine(name);
            }
        }
    }
}
