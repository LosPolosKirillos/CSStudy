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
            bool isOpen = true;
            string word = "";
            string userInput;
            
            while (isOpen)
            {
                Console.WriteLine("Поприветствуй меня!");
                userInput = Console.ReadLine();

                for (int i = 0; i < userInput.Length; i++)
                {
                    if (userInput[i] == ' ' || userInput[i] == ',' || (userInput.Length - 1 == i && userInput[userInput.Length - 1] == 'т'))
                    {
                        if (userInput[i] != ' ' && userInput[i] != ',')
                        {
                            word += userInput[i];
                        }

                        if ((word[0] == 'П' || word[0] == 'п') && word[word.Length - 1] == 'т')
                        {
                            Console.WriteLine("Привет!");
                            isOpen = false;
                            break;
                        }

                        word = "";
                    }
                    else
                    {
                        word += userInput[i];
                    }

                }
            }
        }
    }
}
