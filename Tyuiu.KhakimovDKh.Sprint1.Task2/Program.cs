using Tyuiu.KhakimovDKh.Sprint1.Task2.V22.Lib;
namespace Tyuiu.KhakimovDKh.Sprint1.Task2_;
    internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = ("Спринт #1 | Выполнил:Хакимов Д.Х. | ИИПб-24-2");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил:  Хакимов Достонбек Хисравович| ИИПб-24-2                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToInt32(Console.ReadLine());

        int y;

        Console.WriteLine("Введите значениеY :");
        y = Convert.ToInt32(Console.ReadLine());

        int z;

        Console.WriteLine("Введите значение Z:");
        z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Среднее значение X Y Z-" + ds.CalculateAVGValue(x, y, z));

        Console.ReadLine();
    }
}