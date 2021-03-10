using System;
using System.Text;

/*
 * 5.Необходимо добавить элемент в начало массива и вывести весь массив в консоль. var array = new int[] { 0, 1, 3, 67, 5, 2, 1, -4, -1, 99, 111 };
*/

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var arrayOfInt = new int[] { 0, 1, 3, 67, 5, 2, 1, -4, -1, 99, 111 };
            Console.WriteLine("Исходный массив:");
            foreach (int i in arrayOfInt)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();            
            int[] newArrayOfInt = new int[] { 42, 0, 1, 3, 67, 5, 2, 1, -4, -1, 99, 111};
            Console.WriteLine("Массив с добавленным элементом:");
            foreach (int i in newArrayOfInt)
            {
                Console.Write(i + " ");
            }
        }
    }
}
