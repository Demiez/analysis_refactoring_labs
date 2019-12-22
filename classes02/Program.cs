using System;

namespace classes02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Classes02 ***\n");

            Counter counter = new Counter(5);
            Console.WriteLine($"x = {counter.X}, hx = {counter.HX}, mx = {counter.MX}");
            counter.X = 25;
            Console.WriteLine($"Доступ через свойство Х: {counter.X}");
            counter.MX = 50;
            counter.X = 60;
            Console.WriteLine($"С установленным значением mx = {counter.MX}, попыткой присвоить X = 60: {counter.X}");
            counter.GenerateValue();
            counter.ShowState();

            Console.WriteLine("Индекс 55: {0} при шаге {1}", counter[55], counter.HX);
            Console.WriteLine($"Реальное значение счетчика: {counter.X}");
            counter.HX = 50;
            Console.WriteLine("Индекс 55: {0} при шаге: {1}", counter[55], counter.HX);
            // counter[12] = 2; - error => readonly
            Console.WriteLine($"Реальное значение счетчика: {counter.X}");

            Console.ReadLine();
        }
    }
}

