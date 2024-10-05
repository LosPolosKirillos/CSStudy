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
            Random random = new Random();
            string[,] cells = new string[3, 3] {
                { "-", "-", "-" },
                { "-", "-", "-" },
                { "-", "-", "-" }
            };
            int line = -1, column = -1;

            while (true)
            {
                drawBoard(cells);

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

                    if (checkVictory(cells))
                    {
                        Console.Clear();
                        drawBoard(cells);
                        Console.WriteLine("Победа игрока!");
                        break;
                    }

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

                    if (checkVictory(cells, "o"))
                    {
                        Console.Clear();
                        drawBoard(cells);
                        Console.WriteLine("Победа рандома!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Эта ячейка занята!");
                }
            }
        }

        static bool checkVictory(string[,] board, string symbol = "x")
        {
            if (board[0, 0] == symbol && board[0, 1] == symbol && board[0, 2] == symbol) { return true; }
            else if (board[1, 0] == symbol && board[1, 1] == symbol && board[1, 2] == symbol) { return true; }
            else if (board[2, 0] == symbol && board[2, 1] == symbol && board[2, 2] == symbol) { return true; }
            else if (board[0, 0] == symbol && board[1, 0] == symbol && board[2, 0] == symbol) { return true; }
            else if (board[0, 1] == symbol && board[1, 1] == symbol && board[2, 1] == symbol) { return true; }
            else if (board[0, 2] == symbol && board[1, 2] == symbol && board[2, 2] == symbol) { return true; }
            else if (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) { return true; }
            else if (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol) { return true; }
            else { return false; }
        }

        static void drawBoard(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (j < board.GetLength(1) - 1)
                    {
                        Console.Write(board[i, j] + " | ");
                    }
                    else
                    {
                        Console.Write(board[i, j] + "\n");
                    }
                }
                if (i < board.GetLength(0) - 1)
                {
                    Console.WriteLine("--  --  --");
                }
            }
        }
    }
}
