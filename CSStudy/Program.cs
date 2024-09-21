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
            Random random = new Random();
            float health1 = random.Next(90, 110);
            int damage1 = random.Next(7, 35);
            int armor1 = random.Next(45, 100);

            float health2 = random.Next(80, 120);
            int damage2 = random.Next(5, 40);
            int armor2 = random.Next(65, 100);

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 1);
            Console.WriteLine($"Гладиатор 1 - {health1} здоровья, {damage1} наносимый урон, {armor1} броня.");
            Console.SetCursorPosition(0, 3);
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine($"Гладиатор 2 - {health2} здоровья, {damage2} наносимый урон, {armor2} броня.");

            Console.SetCursorPosition(0, 5);
            Console.ForegroundColor = ConsoleColor.Black;
            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(random.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle(random.Next(0, damage1 + 1)) / 100 * armor2;

                Console.WriteLine($"Здоровье гладиатора 1: {health1}");
                Console.WriteLine($"Здоровье гладиатора 2: {health2}");
            }

            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья, \nоба гладиатора погибли.");
            }
            else if (health1 <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Гладиатор 1\n - пал.");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (health2 <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Гладиатор 2\n - пал.");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }
}
