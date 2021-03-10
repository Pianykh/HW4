using System;
using System.Text;

/*
 * 11 *.Пользователь может ввести сколько угодно данных в таблицу, 
 * формат ввода данных 23; Dima; Petrov; Dnepr;.
 * Если он напишет stop, то программа выведет ему все данные, в таблице вида:
 * | Age | First Name | Second Name | City |
 * | 23 | Dima | Petrov | Dnepr |
*/

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string[] usersArray = new string[1];
            Console.WriteLine("Введите данные в формате \"23; Dima; Petrov; Dnepr;\":");

            int currentUserCounter = 0;
            while (true)
            {
                string inputString = Console.ReadLine();
                if (inputString == "stop")
                {
                    break;
                }
                usersArray[currentUserCounter] = inputString.Replace(";", "");
                Array.Resize(ref usersArray, usersArray.Length + 1);
                currentUserCounter++;
                Console.WriteLine("Введите следующие данные, или введите \"stop\" для вывода таблицы");
            }
            Console.WriteLine("| Age | First Name | Second Name | City |");
            for (int i = 0; i < usersArray.Length - 1; i++)
            {
                string[] currentUser = usersArray[i].Split(" ");
                Console.Write("| " + currentUser[0]);
                if (currentUser[0].Length < 3)
                {
                    for (int s = 0; s < (3 - currentUser[0].Length); s++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(" | " + currentUser[1]);
                if (currentUser[1].Length < 10)
                {
                    for (int s = 0; s < (10 - currentUser[1].Length); s++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(" | " + currentUser[2]);
                if (currentUser[2].Length < 11)
                {
                    for (int s = 0; s < (11 - currentUser[2].Length); s++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(" | " + currentUser[3]);
                if (currentUser[3].Length < 4)
                {
                    for (int s = 0; s < (4 - currentUser[3].Length); s++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(" |");
                Console.WriteLine();
            }
        }
    }
}
