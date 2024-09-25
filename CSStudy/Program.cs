using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[,] cells = new string[3, 3] {
                { "-", "-", "-" },
                { "-", "-", "-" },
                { "-", "-", "-" }
            };
            int line = -1, column = -1;
            bool isGamePlaying = true;

            while (isGamePlaying)
            {
                for (int i = 0; i < cells.GetLength(0); i++)
                {
                    for (int j = 0; j < cells.GetLength(1); j++)
                    {
                        if (j < cells.GetLength(1) - 1)
                        {
                            Console.Write(cells[i, j] + " | ");
                        }
                        else
                        {
                            Console.Write(cells[i, j] + "\n");
                        }
                    }
                    if (i < cells.GetLength(0) - 1)
                    {
                        Console.WriteLine("--  --  --");
                    }
                }

                line = -1;
                column = -1;

                while ((line != 0 && line != 1 && line != 2) || (column != 0 && column != 1 && column != 2))
                {
                    Console.Write("Введите номер строки: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            line = 0;
                            break;
                        case "2":
                            line = 1;
                            break;
                        case "3":
                            line = 2;
                            break;
                        default:
                            Console.WriteLine("Неверный индекс.");
                            break;

                    }
                    Console.Write("Введите номер столбца: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            column = 0;
                            break;
                        case "2":
                            column = 1;
                            break;
                        case "3":
                            column = 2;
                            break;
                        default:
                            Console.WriteLine("Неверный индекс.");
                            break;
                    }
                }
                if (cells[line, column] == "-")
                {
                    cells[line, column] = "x";

                    if (cells[0,0] == "x" && cells[0, 1] == "x" && cells[0, 2] == "x") { isGamePlaying = false; break; }
                    else if (cells[1, 0] == "x" && cells[1, 1] == "x" && cells[1, 2] == "x") { isGamePlaying = false; break; }
                    else if (cells[2, 0] == "x" && cells[2, 1] == "x" && cells[2, 2] == "x") { isGamePlaying = false; break; }
                    else if (cells[0, 0] == "x" && cells[1, 0] == "x" && cells[2, 0] == "x") { isGamePlaying = false; break; }
                    else if (cells[0, 1] == "x" && cells[1, 1] == "x" && cells[2, 1] == "x") { isGamePlaying = false; break; }
                    else if (cells[0, 2] == "x" && cells[1, 2] == "x" && cells[2, 2] == "x") { isGamePlaying = false; break; }
                    else if (cells[0, 0] == "x" && cells[1, 1] == "x" && cells[2, 2] == "x") { isGamePlaying = false; break; }
                    else if (cells[0, 2] == "x" && cells[1, 1] == "x" && cells[2, 0] == "x") { isGamePlaying = false; break; }

                    while (true)
                    {
                        line = random.Next(0, 3);
                        column = random.Next(0, 3);
                        if (cells[line, column] == "-")
                        {
                            cells[line, column] = "o";
                            break;
                        }
                    }
                    if (cells[0, 0] == "o" && cells[0, 1] == "o" && cells[0, 2] == "o") { isGamePlaying = false; break; }
                    else if (cells[1, 0] == "o" && cells[1, 1] == "o" && cells[1, 2] == "o") { isGamePlaying = false; break; }
                    else if (cells[2, 0] == "o" && cells[2, 1] == "o" && cells[2, 2] == "o") { isGamePlaying = false; break; }
                    else if (cells[0, 0] == "o" && cells[1, 0] == "o" && cells[2, 0] == "o") { isGamePlaying = false; break; }
                    else if (cells[0, 1] == "o" && cells[1, 1] == "o" && cells[2, 1] == "o") { isGamePlaying = false; break; }
                    else if (cells[0, 2] == "o" && cells[1, 2] == "o" && cells[2, 2] == "o") { isGamePlaying = false; break; }
                    else if (cells[0, 0] == "o" && cells[1, 1] == "o" && cells[2, 2] == "o") { isGamePlaying = false; break; }
                    else if (cells[0, 2] == "o" && cells[1, 1] == "o" && cells[2, 0] == "o") { isGamePlaying = false; break; }
                }
                else
                {
                    Console.WriteLine("Эта ячейка занята!");
                }
            }
            
            if (cells[line, column] == "x")
            {
                Console.WriteLine("Победа игрока!");
            }
            else
            {
                Console.WriteLine("Победа рандома!");
            }
        }
    }
}
