using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 5;
            string password = "1234";
            string userInput;

            for (int i = 0; i < triesCount; i++)
            {
                Console.Write("Введите неверный пароль:");
                userInput = Console.ReadLine();
                if (userInput != password)
                {
                    Console.WriteLine("Мужиик");
                    break;
                }
                else
                {
                    Console.WriteLine("Введён верный пароль!");
                    Console.WriteLine("У вас осталось попыток: " + (triesCount - i - 1) + ".");
                }
            }
        }
    }
}
