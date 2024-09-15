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
            int playerHealth = 1000;
            int playerDamage = 5;
            int enemyHealth = 1000;
            int enemyDamage = 5;

            Console.WriteLine("Здоровье перед боем:");
            Console.WriteLine($"Игрок - {playerHealth}.");
            Console.WriteLine($"Противник - {enemyHealth}.");

            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;
            }

            Console.WriteLine($"Оставшееся здоровье игрока: {playerHealth}.");
            Console.WriteLine($"Оставшееся здоровье противника: {enemyHealth}.");

            if (playerHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья.");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Победа игрока.");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Победа противника.");
            }

        }
    }
}
