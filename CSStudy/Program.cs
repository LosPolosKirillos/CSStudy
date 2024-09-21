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
            int[] array = { 2, 3, 4, 7, 8, -4, 25, 14 };
            int maxElement = int.MinValue;
            int minElement = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }
            }

            Console.WriteLine(maxElement);
            Console.WriteLine(minElement);
        }
    }
}
