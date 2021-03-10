using System;
using System.Text;
using System.Text.RegularExpressions;
/*
* 13.var array = new[, ,] { { { "(((&Y@#06u%^&", "m6u%$^s!t", " t0" }, 
*                              { "k@!!^n0!@w", "?*()h0&&w", "!t#$!0*" }, 
*                              { " !@#w0)(r&*(&k ", "&*w*i6t^h%", "a@#$r$$$$r@ay#%s" }, 
*                              { "!@a@!##@n!@#!@d##", "w*i6t^h%", "!@#!$%$c!@#!y^&*^&*c$%^l$%^e$%^s!#@!@" } } };
* 1. Убрать все спец.символы в словах массива.
* 2. Заменить все нули на о, убрать все цифры, убрать все лишние пробелы.
* 3. Собрать из всех полученых слов предложение и вывести в консоль.
*/
namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var array = new[, ,] { { { "(((&Y@#06u%^&", "m6u%$^s!t", " t0" },
                    { "k@!!^n0!@w", "?*()h0&&w", "!t#$!0*" },
                    { " !@#w0)(r&*(&k ", "&*w*i6t^h%", "a@#$r$$$$r@ay#%s" },
                    { "!@a@!##@n!@#!@d##", "w*i6t^h%", "!@#!$%$c!@#!y^&*^&*c$%^l$%^e$%^s!#@!@" } 
            } };
            Regex regexDigitsAndLetters = new Regex(@"[\W]+");
            Regex regexDigits = new Regex(@"[0-9]");
            string resultString = "";
            foreach (string element in array)
            {
                resultString += regexDigits.Replace(regexDigitsAndLetters.Replace(element, "").Replace("0", "o"), "");                
                resultString += " ";
            }
            Console.WriteLine(resultString);
        }

    }
}
