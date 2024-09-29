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
            Console.CursorVisible = false;
            Random random = new Random();
            char[,] map =
            {
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', 'X', ' ', '#', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', '#', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', 'X', ' ', '#', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
            };

            int userX = 5, userY = 5;
            char[] bag = new char[1];
            int[] enemies = { random.Next(1, map.GetLength(0) - 1), random.Next(10, map.GetLength(1) - 4) };
            int enemyMoveBorder = 0;
            bool gameOn = true;

            while (gameOn)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write("Сумка: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < enemies.Length; i++)
                {
                    int y = enemies[i];
                    int x = enemies[i + 1];
                    Console.SetCursorPosition(x, y);
                    Console.Write('*');
                    i++;
                }

                Console.SetCursorPosition(userX, userY);
                Console.Write('@');
                ConsoleKeyInfo charkey = Console.ReadKey();
                switch (charkey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userY - 1, userX] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userY + 1, userX] != '#')
                        {
                            userY++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userY, userX - 1] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userY, userX + 1] != '#')
                        {
                            userX++;
                        }
                        break;
                }

                if (enemyMoveBorder == 6)
                {
                    enemyMoveBorder = 0;
                }

                for (int i = 0; i < enemies.Length; i++)
                {
                    if (enemies[i] == userY && enemies[i + 1] == userX)
                    {
                        gameOn = false;
                        break;
                    }

                    switch (enemyMoveBorder)
                    {
                        case 0:
                        case 1:
                        case 2:
                            enemies[i + 1]++;
                            break;
                        case 3:
                        case 4:
                        case 5:
                            enemies[i + 1]--;
                            break;
                    }
                    i++;
                }

                if (gameOn == false)
                {
                    Console.SetCursorPosition(0, 17);
                    Console.Write("GAME OVER! ");
                    break;
                }

                enemyMoveBorder++;

                if (map[userY, userX] == 'X')
                {
                    map[userY, userX] = 'o';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = 'X';
                    bag = tempBag;

                    int[] tempEnemies = new int[enemies.Length + 2];
                    for (int i = 0; i < enemies.Length;i++)
                    {
                        tempEnemies[i] = enemies[i];
                    }
                    tempEnemies[tempEnemies.Length - 2] = random.Next(1, map.GetLength(0) - 1);
                    tempEnemies[tempEnemies.Length - 1] = random.Next(10, map.GetLength(1) - 4);
                    enemies = tempEnemies;
                }

                Console.Clear();
            }
        }
    }
}
