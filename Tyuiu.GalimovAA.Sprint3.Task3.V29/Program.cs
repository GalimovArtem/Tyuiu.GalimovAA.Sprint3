using System;
using Tyuiu.GalimovAA.Sprint3.Task3.V29.Lib;

namespace Tyuiu.GalimovAA.Sprint3.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string value = "chgr vhhtg hnht";
            char item = 'h';

            Console.Title = "Спринт #3 | Выполнил: Галимов А.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы h в строке:          *");
            Console.WriteLine("* chgr vhhtg hnht                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Удаляемый символ: " + item);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.DeleteCharInString(value, item);
            Console.WriteLine("Результат после удаления всех символов '" + item + "': " + result);

            Console.ReadKey();
        }
    }
}