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
            float money;
            int years;
            int percent = 1;

            Console.Write("Введите кол-во денег на вкладе: ");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("Кол-во лет: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш вклад будет открыт под {percent}% годовых.");

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine($"В этом году ваш баланс: {money}.");
                Console.ReadKey();

            }
        }
    }
}
