using Tyuiu.KhakimovDKh.Sprint1.Task7.V25.Lib;
namespace Tyuiu.KhakimovDKh.Sprint1.Task7.V25
{
    
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Хакимов Д.Х | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итоговых проектов по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Хакимов Достонбек Хисравович  | ИИПб-24-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*           y^2 + 6 + cosx^3 + xy - 2x^2                                  *");
            Console.WriteLine("* z = e^x - ----------------------------                                  *");
            Console.WriteLine("*              sin(x^4 + 13) + 9y - 2                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите x : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y : ");
          double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
