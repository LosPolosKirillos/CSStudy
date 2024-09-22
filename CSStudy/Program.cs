using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[15, 2];
            int[,] array1 = new int[2, 2]
            {
                { 9, 2 },
                { 2, 2 },
            };

            Random random = new Random();

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = random.Next(0, 10);
                    Console.Write(array1[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine(array[0, 0]);
            }
        }
    }
}
