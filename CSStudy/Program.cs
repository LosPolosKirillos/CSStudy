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
            int value = 0;
            string line = "Hello ";
            Add(ref value, 10);
            Add(ref line, 5);
            Console.WriteLine($"{value}, {line}");
        }

        static void Add(ref int value, int amount)
        {
            value += amount;
        }

        static void Add(ref string line, int amount)
        {
            string lineToAdd = "";
            for (int i = 0; i < amount; i++)
            {
                lineToAdd += "_";
            }
            line += lineToAdd;
        }
    }
}
