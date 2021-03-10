using System;
using System.Text;

/*
 * 1.Вывести все элементы массива используя все виды циклов.
*/

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int whileIterator = 0;
            int doWhileIterator = 0;
            int[] arrayOfInt = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Вывод циклом foreach:");
            foreach (int k in arrayOfInt)
            {
                Console.Write(k + " ");                
            }
            Console.WriteLine();
            Console.WriteLine("Вывод циклом for:");
            for (int k = 0; k < arrayOfInt.Length; k++)
            {
                Console.Write(arrayOfInt[k] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Вывод циклом while:");            
            while (whileIterator < arrayOfInt.Length)
            {
                Console.Write(arrayOfInt[whileIterator] + " ");
                whileIterator++;
            }
            Console.WriteLine();
            Console.WriteLine("Вывод циклом do-while:");
            do
            {
                Console.Write(arrayOfInt[doWhileIterator] + " ");
                doWhileIterator++;
            } while (doWhileIterator < arrayOfInt.Length);
        }
    }
}
