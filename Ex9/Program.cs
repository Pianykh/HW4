using System;
using System.Text;

/*
* 9.Пользователь вводит строку и в ответ ему должно выводиться сколько слов, 
* которые начинаются с заглавной буквы находятся в предложении и также выводятся 
* все эти слова через запятую. Учесть, что таких слов может и не быть.
*/


namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите строку:");
            string outputString = "";
            string inputString = Console.ReadLine();
            inputString = inputString.Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").Replace("!", "").Replace(":", "").Replace(";", "");
            string[] wordsArray = inputString.Split(" ");
            int wordsCounter = 0;
            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (Char.IsUpper(wordsArray[i][0])){
                    wordsCounter++;
                }
            }
            if (wordsCounter == 0)
            {
                Console.WriteLine("В предложении нет слов с заглавной буквы.");
            }
            else
            {
                Console.WriteLine($"В предложении {wordsCounter} слов с заглавной буквы.");
                Console.WriteLine("Перечень слов с заглавной буквы:");
                for (int i = 0; i < wordsArray.Length; i++)
                {
                    if (Char.IsUpper(wordsArray[i][0]))
                    {
                        outputString += wordsArray[i] + ", ";
                    }                    
                }
                outputString = outputString.TrimEnd(' ').TrimEnd(',');
                Console.WriteLine(outputString);
            }
        }
    }
}
