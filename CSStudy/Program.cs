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
            int health = 10, maxHealth = 10, mana = 4, maxMana = 10;

            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Green, 2, '|');
                DrawBar(mana, maxMana, ConsoleColor.Blue, 3);

                Console.SetCursorPosition(0, 6);
                Console.Write("Введите значение, на которое хотите изменить шкалу жизни: ");
                health += Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение, на которое хотите изменить шкалу маны: ");
                mana += Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            }
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = '_')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = 0;i < maxValue-value; i++)
            {
                bar += symbol;
            }

            Console.Write(bar + ']');
        }
    }
}
