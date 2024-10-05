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
            int value;

            minusValue(out value);
            Console.WriteLine(value);
        }

        static int minusValue(out int arg)
        {
            arg = 0;
            arg -= 3;
            return arg;
        }
    }
}
