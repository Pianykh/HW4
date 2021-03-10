using System;
using System.Text;
/*
* 3.Выводить все элементы массива пока не встретится элемент -1.  var arrayOfInt = new int[] { 0, 7, 3, 4, 5, 6, -1, 8, 9 };
*/
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var arrayOfInt = new int[] { 0, 7, 3, 4, 5, 6, -1, 8, 9 };
            Console.WriteLine("Исходный массив:");
            foreach (int i in arrayOfInt)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Вывод массива до элемента -1:");
            foreach (int i in arrayOfInt)
            {
                if (i == -1) break;
                Console.Write(i + " ");
            }
        }
    }
}
