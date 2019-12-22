using System;

namespace classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Classes ***\n");
            Counter counter01 = new Counter(); // использовали дефолтный конструктор без параметров
            counter01.GenerateValue();
            counter01.ShowState(); // Ожидаем 11
            counter01.GenerateValue();
            counter01.ShowState(); // Ожидаем 21

            Counter counter03 = new Counter(5, 10); // используем перегрузку и 3й метод
            counter03.GenerateValue();
            counter03.ShowState(); // Ожидаем 15
            counter03.IncreaseCounter(100);
            counter03.ShowState(); // Ожидаем 115

            Console.ReadLine();
        }
    }
}
