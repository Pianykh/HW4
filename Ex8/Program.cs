using System;
/*
 * 8.Вывести двумерный массив в консоль, чтобы элементы рассполагались в виде матрицы, негативные цифры не должны выводиться.
 * var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };
*/

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    if (array[i, k] > 0)
                    {
                        Console.Write(array[i, k] + " ");
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}
