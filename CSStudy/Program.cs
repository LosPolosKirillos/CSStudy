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
            string userAnswer;
            bool askQuestion;
            Console.WriteLine("Масса обьекта m = 2 г, тогда сила тяжести," +
                " которая действует на объект Ft = ?:");
            Console.WriteLine("- a) 20Н");
            Console.WriteLine("- b) 0.02Н");
            Console.WriteLine("- c) 2Н");
            Console.WriteLine("- d) 0.002Н");
            Console.WriteLine("Образец ответа: a)");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("");
            }

            askQuestion = true;
            userAnswer = "";
            while (askQuestion)
            {
                Console.Write("Ввод:");
                userAnswer = Console.ReadLine();

                if (userAnswer != "a)" && userAnswer != "b)" && userAnswer != "c)" && userAnswer != "d)")
                {
                    continue;
                }
                else
                {
                    switch (userAnswer)
                    {
                        case "a)":
                        case "c)":
                        case "d)":
                        default:
                            Console.WriteLine("Ответ неверный!");
                            break;
                        case "b)":
                            Console.WriteLine("Ответ правильный!");
                            askQuestion = false;
                            break;
                    }
                }
            }
        }
    }
}
