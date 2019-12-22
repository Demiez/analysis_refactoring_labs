using System;

namespace classes02
{
    class Counter
    {
        private int x, hx, mx; // значение, шаг, макс
        private int[] arrValues = new int[100]; // предположим, что индексируем значения счетчика до 100 итераций

        public int X
        {
            get => x;
            set => x = value <= mx ? value : mx; // учитываем максимальное значение ТОЛЬКО при присвоении, можно валидировать также в других местах
        }

        public int HX
        {
            get => hx;
            set => hx = value;
        }

        public int MX
        {
            get => mx;
            set => mx = value;
        }

        public int this[int index] // валидацию на макс значение для индексатора не добавлял т.к. нет в задании
        {
            get
            {
                for(int i = 0; i < arrValues.Length; i++)
                {
                    arrValues[i] = i == 0 ? x : arrValues[i-1] + hx;
                }
                return arrValues[index];
            }
        }

        // Чейнинг
        public Counter()
            : this(1, 1, 100) { }
        public Counter(int initx)
            :this(initx, 1, 100) { }
        public Counter(int initx, int inithx)
            :this(initx, inithx, 100) { }
        public Counter(int initx, int inithx, int initmx)
        {
            x = initx;
            hx = inithx;
            mx = initmx;
        }

        // Методы
        public int GenerateValue()
            => x += hx;

        public int IncreaseCounter(int constant)
            => x += constant;

        public void ShowState()
            => Console.WriteLine($"Текущее состояние счетчика: {x}");
    }
}
