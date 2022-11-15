using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_day2
{
    

    internal class rectanguarArray
    {
        static void Main(string[] args)
        {
            int rows, columns;
            Console.WriteLine("Rows:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Columns:");
            columns = int.Parse(Console.ReadLine());
            int[,]table=new int[rows,columns];

            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine("Input for Row {0}",i);
                for(int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Enter value for row {0} and column{1}",i,j);
                    
                    table[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0}\t",table[i, j]);
                   
                     
                }
                Console.WriteLine();
            }
            //while (true) {
            //    Console.ReadLine();
            //}
            
        }
    }
}
