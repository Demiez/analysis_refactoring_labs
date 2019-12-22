using System;

namespace classes
{
    class Counter
    {
        //State
        public int x; // значение
        public int hx; // шаг

        // Конструктор без параметров
        public Counter()
        {
            // внутри конструктора можем установить кастомные дефолтные значения, или им будут присвоены дефолтные для типа данных(у нас int)
            x = 1;
            hx = 10;
        }

        // Конструктор с одним параметром (начальное значение счетчика)
        public Counter(int initx)
        {
            x = initx;
        }

        // Конструктор с двумя параметрами (начальное значение и шаг)
        public Counter(int initx, int inithx)
        {
            x = initx;
            hx = inithx;
        }

        // Методы
        public void GenerateValue()
            => x += hx;

        public int IncreaseCounter(int constant)
            => x += constant;

        public void ShowState()
            => Console.WriteLine($"Текущее состояние счетчика: {x}");



    }
}
