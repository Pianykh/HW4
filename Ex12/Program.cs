using System;
using System.Text;

/*
 * 12.Создать двумерный массив 5х5. Заполнить рандомными значениями от 0 до 20. 
 * НЕ показывать пользоветелю. Спрашивать по одному числу у пользователя, если введенное
 * число есть в массиве - выводить как на картинке: http://prntscr.com/10drjzz*/

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string[,] numbersMatrix = new string[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    numbersMatrix[i, k] = Convert.ToString(random.Next(0, 21));
                }
            }
            string[,] outputMatrix = new string[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    outputMatrix[i, k] = "*";
                }
            }
            while (true)
            {
                Console.Clear();
                bool hasHiddenNumber = false;
                for (int i = 0; i < outputMatrix.GetLength(0); i++)
                {
                    for (int k = 0; k < outputMatrix.GetLength(1); k++)
                    {                        
                        Console.Write(outputMatrix[i, k] + " ");
                        if(outputMatrix[i,k] == "*")
                        {
                            hasHiddenNumber = true;
                        }
                    }
                    Console.WriteLine();
                }
                if (hasHiddenNumber == false)
                {
                    Console.WriteLine("Матрица полностью разгадана");
                    break;
                } 
                Console.WriteLine("Введите число:");
                string number = Console.ReadLine();
                for (int i = 0; i < 5; i++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (number == numbersMatrix[i, k])
                        {
                            outputMatrix[i, k] = number;
                        }
                    }
                }
            }
        }
    }
}
