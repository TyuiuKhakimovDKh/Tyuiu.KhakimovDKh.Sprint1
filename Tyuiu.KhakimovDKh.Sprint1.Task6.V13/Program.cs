using Tyuiu.KhakimovDKh.Sprint1.Task6.V13.Lib;
namespace Tyuiu.KhakimovDKh.Sprint1.Task6.V13;
public class Program
{
    public static void Main(string[] args)
    {
        //Console.Title = "Спринт #1 | Выполнил: Хакимов Д. Х. | ИИПб 24-2";
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт#1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                       *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #13                                                            *");
        Console.WriteLine("* Выполнил: Хакимов Достонбек Хисравович | ИИПб 24-2                      *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                *");
        Console.WriteLine("*Написать программу: пользователь вводит текст. Проверить, что буквы     *");
        Console.WriteLine("*строки упорядочены по алфавиту                                          *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine();
        bool res = ds.CheckWordsAlphabet(str);
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}

