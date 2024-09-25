using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] petrovich = new int[3];
            int[] ivanovich = new int[5];
            int[] sidorovich;

            petrovich = ivanovich;

            petrovich[0] = 5;
            petrovich[1] = 3;

            sidorovich = petrovich;

            sidorovich[2] = 7;
            sidorovich[0] = 10;

            Console.WriteLine(ivanovich[0]);
            Console.WriteLine(ivanovich[1]);

            petrovich = new int[10];

            Console.WriteLine(petrovich[0]);
        }
    }
}
