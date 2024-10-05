using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CSStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] group = { 1, 2, 3 };

            group = minusValue(group, 1, 4);
            Console.WriteLine(group[1]);
        }

        static int[] minusValue(int[] list, int index, int value = 2)
        {
            list[index] -= value;
            return list;
        }
    }
}
