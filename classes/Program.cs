using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Classes ***\n");
            Counter counter01 = new Counter(); // использовали дефолтный конструктор без параметров
            counter01.generateValue();
            counter01.showState(); // Ожидаем 11
            counter01.generateValue();
            counter01.showState(); // Ожидаем 21

            Counter counter03 = new Counter(5, 10); // используем перегрузку и 3й метод
            counter03.generateValue();
            counter03.showState(); // Ожидаем 15
            counter03.increaseCounter(100);
            counter03.showState(); // Ожидаем 115

            Console.ReadLine();
        }
    }
}
