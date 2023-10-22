using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint3.Task3.V30.Lib;

namespace Tyuiu.PaulikKV.Sprint3.Task3.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Паулик К.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры  C#                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв y,       *");
            Console.WriteLine("* находящихся на соседних позициях в строке: fyyklbtyn ygrc vfyyyyh       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "fyyklbtyn ygrc vfyyyyh";
            char chr = 'y';
            int count = ds.GetMaxCharCount(value, chr);

            Console.WriteLine(" Исходная строка : " + value);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Максимальное количкество букв Y в строке, находящихся на соседних  =  " + count);
            Console.ReadKey();
        }
    }
}
