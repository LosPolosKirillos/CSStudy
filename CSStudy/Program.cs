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
            int playerHealth = 10;
            int playerDamage = random.Next(5, 10);
            int enemyHealth = random.Next(10, 30);
            int enemyDamage = playerDamage - random.Next(0, 4);

            Console.WriteLine("Здоровье перед боем:");
            Console.WriteLine($"Игрок - {playerHealth}.");
            Console.WriteLine($"Противник - {enemyHealth}.");

            while (playerHealth > 0 && enemyHealth > 0)
            {
                if (random.Next(0, 2) == 1)
                {
                    playerHealth -= enemyDamage;
                }
                else
                {
                    Console.WriteLine("Уворот игрока!");
                }

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
