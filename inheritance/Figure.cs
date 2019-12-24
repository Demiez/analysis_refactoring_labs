using System;
using System.Linq;


namespace inheritance
{
    abstract public class Figure
    {
        /* 
         Создадим абстрактый класс Фигура, включим в него методы, которые перемещает фигуру по плоскости, возвращают ее площадь, периметр. +++ строку символов, отражающую имя класса и состояние объекта.
        */
        public abstract float GetArea();

        public abstract float GetPerimeter();

        public abstract void Move(float dx, float dy, float dz);


        public Figure(string n)
        {
            name = n;
        }
        private string name;
        public void ShowName()
        {
            Console.WriteLine(name);
        }

    }

    /* Для перехода к отрезку, образуем класс точка, так как отрезок - часть прямой между двумя точками */
    public class Point : Figure
    {
        public Point(float x = 0, float y = 0, float z = 0) : base("Figure")
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Point(Point other) : this(other.X, other.Y, other.Z) { }

        public float X { get; set; }

        public float Y { get; set; }

        public float Z { get; set; }

        public override float GetArea()
        {
            throw new NotSupportedException();
        }

        public override float GetPerimeter()
        {
            throw new NotSupportedException();
        }

        public override void Move(float dx, float dy, float dz)
        {
            this.X += dx;
            this.Y += dy;
            this.Z += dz;
        }

        public override string ToString()
        {
            return string.Format("Point: ({0}; {1}; {2})", this.X, this.Y, this.Z);
        }

    }

    // Переходим к отрезку, задаем две точки с соответствующими координатами (Point a (X1,Y1,Z1) и Point b (X2,Y1,Z1)
    public class Line : Point
    {
        public Line(Point a, Point b)
        {
            this.X1 = a.X;
            this.Y1 = a.Y;
            this.Z1 = a.Z;
            this.X2 = b.X;
            this.Y2 = b.Y;
            this.Z2 = b.Z;
        }

        public float X1 { get; set; }

        public float Y1 { get; set; }

        public float Z1 { get; set; }

        public float X2 { get; set; }

        public float Y2 { get; set; }

        public float Z2 { get; set; }

        public static float GetDistance(Line a)
        {
            double dx2 = Math.Pow(a.X1 - a.X2, 2);
            double dy2 = Math.Pow(a.Y1 - a.Y2, 2);
            double dz2 = Math.Pow(a.Z1 - a.Z2, 2);
            return (float)Math.Sqrt(dx2 + dy2 + dz2);
        }

        public override float GetArea()
        {
            throw new NotSupportedException();
        }

        public override float GetPerimeter()
        {
            throw new NotSupportedException();
        }

        public override void Move(float dx, float dy, float dz)
        {
            this.X1 += dx;
            this.Y1 += dy;
            this.Z1 += dz;
            this.X2 += dx;
            this.Y2 += dy;
            this.Z2 += dz;
        }

        public override string ToString()
        {
            return string.Format($"Line length ({GetDistance(this)}) between Point1({this.X1}; {this.Y1}; {this.Z2}) and Point2({this.X2}, {this.Y2}, {this.Z2})");
        }
    }

    public class Rhombus : Point
    {
        public readonly Point[] points;

        public Rhombus(float size)
        {
            if (size <= 0) throw new ArgumentException();
            this.points = new[] { new Point(0, size), new Point(size, size), new Point(size, 0), new Point(0, 0) };
            if (Line.GetDistance(new Line(points[0], points[1])) != Line.GetDistance(new Line(points[2], points[3])))
                throw new ArgumentException(); // проверяем равенство граней ромба
        }

        public Rhombus(Rhombus other)
        {
            this.points = other.points.Select(point => new Point(point)).ToArray();
        }

        public override float GetArea()
        {
            return (float)Math.Pow(Line.GetDistance(new Line(this.points[0], this.points[1])), 2);
        }

        public override float GetPerimeter()
        {
            return 4 * Line.GetDistance(new Line(this.points[0], this.points[1]));
        }

        public Point GetPoint(int index)
        {
            return new Point(this.points[index]);
        }

        public override void Move(float dx, float dy, float dz)
        {
            foreach (Point point in this.points)
            {
                point.Move(dx, dy, dz);
            }
        }

        public override string ToString()
        {
            string description = string.Join(", ", this.points.Select(point => string.Format("({0}; {1}; {2})", point.X, point.Y, point.Z)));
            return string.Format($"Rhombus: {description}");
        }
    }

    class Parallelepiped : Rhombus
    {
        public double height;
        private readonly Point[] basis;

        public Parallelepiped(double h, Rhombus rhombus): base(rhombus)
        {
            this.height = h;
            this.basis = rhombus.points;
        }

        public override float GetPerimeter()
        {
            return 4 * Line.GetDistance(new Line(this.basis[0], this.basis[1]));
        }

        public override void Move(float dx, float dy, float dz)
        {
            foreach (Point point in this.basis)
            {
                point.Move(dx, dy, dz);
            }
        }

        public override string ToString()
        {
            string baseDescription = string.Join(", ", this.basis.Select(point => string.Format("({0}; {1}; {2})", point.X, point.Y, point.Z)));
            return string.Format($"Parallelepiped: base => {baseDescription} and height {this.height}");
        }
    }
}
