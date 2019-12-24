### analysis_refactoring_labs
### Анализ и рефакторинг кода ПО

### СОЗДАНИЕ КЛАССОВ. КОНСТРУКТОРЫ.  МЕТОДЫ. (вариант 6, sln classes)
Создать класс  Counter(десятичный счетчик), разработав следующие элементы класса:
a.	Поля:
•		int x;//состояние счетчика
•		int hx;//шаг счетчика
b.	Конструкторы, позволяющие создать экземпляр класса:
•		без параметров;
•		с одним параметром (начальное значение счетчика)
•	 	с двумя параметрами (начальное значение  счетчика  и  шаг счетчика)
c.	Методы, позволяющие:
•		сгенерировать и вернуть    следующее значение счетчика;
•		вернуть   текущее значение счетчика;
•		увеличить значение  счетчика на  константу.

### КЛАССЫ. ИНДЕКСАТОРЫ. СВОЙСТВА (вариант 6, sln classes02)
В класс  Counter(десятичный счетчик), добавить:
a.	Свойства:
•	позволяющее установить и  получить текущее значение счетчика (доступное для чтения и записи);
•	позволяющее установить и получить шаг счетчика (доступное для чтения и записи);
•	максимальное значение счетчика (чтение, запись).
b.	Индексатор, позволяющий по индексу i определить,  чему будет равно  значение счетчика через   i  шагов (только чтение).

### НАСЛЕДОВАНИЕ (вариант 16 % 7 = 2, sln inheritance)
Объемные фигуры задаются  добавлением   плоским   фигурам   высоты:
2 - Отрезок,  ромб, параллелепипед<br>
а) Наследование. Определите иерархию  классов отрезок,  ромб, параллелепипед, связанных отношением наследования. Определите в этих классах методы, которые перемещает фигуру по плоскости, возвращают ее площадь, периметр (для объемных  фигур – периметр основания), и строку символов, отражающую имя класса и состояние объекта.  Продемонстрируйте  работу   с классами.<br>
б*) Добавьте абстрактный класс «Фигура» в вашу систему классов, включите в него все методы прочих классов.  Создайте  массив  ссылок на   базовый класс «Фигура»,  заполните  его  различными  фигурами,  продемострируйте  работу   с методами  различных  элементов массива.
