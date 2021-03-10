using System;
using System.Text;

/*
 * 2.Расположить все элементы массива в обратном порядке и вывести в консоль, без использования Array.Revers();
*/

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int[] arrayOfInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            Console.WriteLine("Исходный массив:");
            foreach (int i in arrayOfInt)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int endPointer = 0;
            for (int startPointer = arrayOfInt.Length - 1; startPointer >= arrayOfInt.Length / 2 + arrayOfInt.Length % 2; startPointer--, endPointer++)
            {
                arrayOfInt[endPointer] = arrayOfInt[endPointer] ^ arrayOfInt[startPointer];
                arrayOfInt[startPointer] = arrayOfInt[endPointer] ^ arrayOfInt[startPointer];
                arrayOfInt[endPointer] = arrayOfInt[endPointer] ^ arrayOfInt[startPointer];
            }
            Console.WriteLine("Массив в обратном порядке");
            foreach (int i in arrayOfInt)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
