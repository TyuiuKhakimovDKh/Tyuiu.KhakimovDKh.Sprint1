using Tyuiu.KhakimovDKh.Sprint1.Task3.V16.Lib;
namespace Tyuiu.KhakimovDKh.Sprint1.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил:Хакимов Достонбек Хисравович . | ИИПб-24-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Хакимов Достонбек Хисравович  | ИИПб-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
          
            Console.Write("Введите первый корень (x1): ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второй корень (x2): ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double b = ds.CoeffOfQuadraticEquation(x1, x2);
            Console.WriteLine($"Коэффициент b (округлён до 3 знаков): {b}");
            Console.ReadKey();
        }
    }
}