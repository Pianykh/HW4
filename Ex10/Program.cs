using System;
using System.Text;

/*
* 10 *.Пользователь вводит 6 своих последних зарплат, ему выводится максимальная, минимальная, средняя зп и общая сумма. 
* Использовать массивы и циклы. Запрещено использовать LINQ
*/

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int maximumSalary = 0;
            int minimumSalary;            
            int totalSalary = 0;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите шесть своих последних зарплат через пробел");
            string inputString = Console.ReadLine();
            string[] lastSalariesStringArray = inputString.Split(" ");
            int[] lastSalariesIntArray = new int[6];
            for (int i = 0; i < lastSalariesIntArray.Length ; i++)
            {
                lastSalariesIntArray[i] = Convert.ToInt32(lastSalariesStringArray[i]);
            }
            minimumSalary = lastSalariesIntArray[0];
            foreach (int oneSalary in lastSalariesIntArray)
            {
                if(oneSalary > maximumSalary)
                {
                    maximumSalary = oneSalary;
                }
                if (oneSalary < minimumSalary)
                {
                    minimumSalary = oneSalary;
                }
                totalSalary += oneSalary;
            }
            Console.WriteLine($"Максимальная зарплата: {maximumSalary}");
            Console.WriteLine($"Минимальная зарплата: {minimumSalary}");
            Console.WriteLine($"Средняя зарплата: {totalSalary/6}");
            Console.WriteLine($"Общая сумма всех зарплат: {totalSalary}");
        }
    }
}
