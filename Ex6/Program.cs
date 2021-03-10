using System;
using System.Text;
/*
* 6.Вывести сумму всех чисел двумерного массива, нужно использовать циклы. 
* var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };
*/

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            Console.WriteLine($"Сумма элементов массива: {sum}");
        }
    }
}
