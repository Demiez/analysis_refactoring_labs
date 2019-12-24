using System;
using System.Collections.Generic;

namespace inheritance
{
    class Program
    {
        static void Main()
        {
            /* Абстрактный класс «Фигура» с имплементированными в систему классам, методами прочих классов Figure.cs */
            /* Созданы классы Отрезок, Ромб, Параллелепипед */

            // Создадим динамический массив figures к базовому классу Figure («Фигура») и вызовем, к примеру, метод Move (перемещение фигуры)
            var figures = new List<Figure> { new Line(new Point(1, 2, 3), new Point(4, 5, 6)), new Rhombus(4), new Parallelepiped(2, new Rhombus(7))};
            figures.ForEach(figure => figure.Move(5, 0, 0));
            Console.WriteLine(string.Join("\n", figures));

            // Вызовем метод GetPerimeter для ромба и параллелепипеда (для отрезка вернет NotSupportedException, ведь мы не можем посчитать периметр отрезка)
            for (int i = 1; i < figures.ToArray().Length; i++)
                Console.WriteLine(figures[i].GetPerimeter());

            Console.ReadLine();
        }
    }
}
