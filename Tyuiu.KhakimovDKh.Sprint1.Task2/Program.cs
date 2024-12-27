using Tyuiu.KhakimovDKh.Sprint1.Task2.V22.Lib;
namespace Tyuiu.KhakimovDKh.Sprint1.Task2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Хакимов Достонбек Хисравович   | ИИПБ-24-2";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Арифметические операторы в C#                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Хакимов Достонбек Хисравович | ИИПБ-24-2                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, в*");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.              *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int number1;
            int number2;
            int number3;

            Console.WriteLine("введите первое число: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int average = (number1 + number2 + number3) / 3;

      
            Console.WriteLine($"среднее  чисел:{average}");
            Console.ReadKey();
        }
    }
}