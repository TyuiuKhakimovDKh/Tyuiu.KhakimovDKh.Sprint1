﻿using Tyuiu.KhakimovDKh.Sprint1.Task0.V2.Lib;

namespace Tyuiu.KhakimovDKh.Sprint1.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds=  new DataService();
            Console.Title = "Спринт #1 | Выполнил: Хакимов Д.Х | ИИПб-24-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: {Хакимов Достонбек Хисравович                     | ИИПб-24-2 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 3/3*2+12/4/3-2           *");
            Console.WriteLine("* и выводит результат на экране.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 3/3*2+12/4/3-2                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
 }
