using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GbLesson1
{
    class GbLesson1
    {
        static void Main(string[] args)
        {
            #region Задание 1

            Console.WriteLine("Введите Ваше имя:");
                string a = Console.ReadLine();

            Console.WriteLine("Введитее Вашу фамилию:");
                string b = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст:");
                int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Ваш рост:");
                double d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Ваш вес:");
                double e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Имя: " + a + " | Фамилия: " + b + " | Возраст: " + c + " | Рост (в см): " + d + " | Вес (в кг): " + e); // Вариант А (Склеивание)
            Console.WriteLine("Имя: {0} | Фамилия: {1} | Возраст: {2} | Рост (в см): {3} | Вес (в кг): {4}", a, b, c, d, e); // Вариант Б (Форматированный вывод)
            Console.WriteLine($"Имя: {a} | Фамилия: {b} | Возраст: {c} | Рост (в см): {d} | Вес (в кг): {e}"); // Вариант В
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задание 2

            Console.WriteLine("Введите массу (в кг):");
                double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост (в метрах):");
                double h = Convert.ToDouble(Console.ReadLine());

            double l = m / (h * h);

            Console.WriteLine($"Индекс массы тела (ИМТ): {m} / ({h} * {h}) = {l}");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задание 3

            Console.WriteLine("Введите координату x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками с координатами [{0}:{1}] и [{2}:{3}] = {4:F2}", x1, y1, x2, y2, r);
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задание 4

            int one = 1; // Начало варианта А
            int two = 2;

            int temp;

            Console.WriteLine($"Значение первое до обмена: {one} | Значение второе до обмена: {two}");

            temp = one;
            one = two;
            two = temp;

            Console.WriteLine($"Значение первое после обмена: {one} | Значение второе после обмена: {two}");
            Console.ReadLine();
            Console.Clear();

            int ten = 10; // Начало варианта Б*
            int twenty = 20;

            Console.WriteLine($"Значение первое до обмена: {ten} | Значение второе до обмена: {twenty}");

            ten = ten + twenty;
            twenty = ten - twenty;
            ten = ten - twenty;

            Console.WriteLine($"Значение первое после обмена: {ten} | Значение второе после обмена: {twenty}");
            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Задание 5

            Console.WriteLine("Введите Ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию:");
            string lastname = Console.ReadLine();

            Console.WriteLine("В каком городе Вы живёте:");
            string town = Console.ReadLine();

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2); // Вывод информации в центре экрана (Вариант Б)
            Console.WriteLine($"Ваша анкета: | Имя: {name} | Фамилия: {lastname} | Город проживания: {town}"); // Вывод информации на экран (Вариант А)
            Console.ReadLine();
            #endregion
        }
    }
}
