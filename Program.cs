using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._08._22
{
    abstract class GeoFigure
    {
        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public abstract decimal Square();
        public abstract decimal Perimeter();
    }
    class Rectangle : GeoFigure
    {
        public Rectangle()
        {
            name = "Rect001";
            Length = 2.3M;
            Height = 3m;
        }
        public override decimal Square()
        {
            decimal _square = this.length * this.height;
            return _square;
        }
        public override decimal Perimeter()
        {
            return length * 2 + height * 2;
        }

        private decimal Length;

        public decimal length
        {
            get { return Length; }
            set { Length = value; }
        }
        private decimal Height;

        public decimal height
        {
            get { return Height; }
            set { Height = value; }
        }

    }
    class Foursquare : GeoFigure
    {
        public Foursquare()
        {
            name = "Square001";
            length = 3.3m;
        }
        private decimal Length;

        public decimal length
        {
            get { return Length; }
            set { Length = value; }
        }

        public override decimal Square()
        {
            decimal _square = this.Length * this.Length;
            return _square;
        }
        public override decimal Perimeter()
        {
            return length * 4;
        }
    }
    class Triangle : GeoFigure
    {
        public Triangle()
        {
            name = "Triang001";
            AB = 3;
            BC = 4;
            AC = 5;
        }
        private decimal AB;

        public decimal ab
        {
            get { return AB; }
            set { AB = value; }
        }
        private decimal BC;

        public decimal bc
        {
            get { return BC; }
            set { BC = value; }
        }
        private decimal AC;

        public decimal ac
        {
            get { return AC; }
            set { AC = value; }
        }

        public override decimal Square()
        {
            decimal p = (AB + BC + AC) / 2;
            return (decimal)Math.Sqrt((double)(p * (p - AB) * (p - BC) * (p - AC)));
        }
        public override decimal Perimeter()
        {
            return AB + BC + AC;
        }
    }
    class Circle : GeoFigure
    {
        public Circle()
        {
            Radius = 3;
        }
        public decimal Pi = 3.14m;
        private decimal Radius;

        public decimal radius
        {
            get { return Radius; }
            set { Radius = value; }
        }

        public override decimal Square()
        {
            return Pi * (radius * radius);
        }
        public override decimal Perimeter()
        {
            return 2 * Pi * radius;
        }
    }
    class DoWhile
    {
        List<GeoFigure> myList = new List<GeoFigure>();
        public void funcRectangle()
        {
            Rectangle myRectangle = new Rectangle();
            Console.WriteLine("Введите длину прямоугольника: ");
            myRectangle.length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту прямоугольника: ");
            myRectangle.height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя: ");
            myRectangle.name = Console.ReadLine();
            if ((myRectangle.length < 0) | (myRectangle.height < 0))
            {
                myRectangle.length = 0;
                myRectangle.height = 0;
                Console.WriteLine("Данные должны быть больше нуля!");
            }
            else
            {
                myList.Add(myRectangle);
                Console.WriteLine("Фигура добавлена!");
            }
        }
        public void funcFoursquare()
        {
            Foursquare myFoursquare = new Foursquare();
            Console.WriteLine("Введите длину квадрата: ");
            myFoursquare.length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя: ");
            myFoursquare.name = Console.ReadLine();
            if (myFoursquare.length < 0)
            {
                myFoursquare.length = 0;
                Console.WriteLine("Данные должны быть больше нуля!");
            }
            else
            {
                myList.Add(myFoursquare);
                Console.WriteLine("Фигура добавлена!");
            }
        }
        public void funcTriangle()
        {
            Triangle myTringle = new Triangle();
            Console.WriteLine("Введите первую сторону треугольнка: ");
            myTringle.ab = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону треугольнка: ");
            myTringle.bc = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону треугольнка: ");
            myTringle.ac = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя: ");
            myTringle.name = Console.ReadLine();
            if ((myTringle.ab < 0) | (myTringle.bc < 0) | (myTringle.ac < 0))
            {
                myTringle.ab = 0;
                myTringle.bc = 0;
                myTringle.ac = 0;
                Console.WriteLine("Данные должны быть больше нуля!");
            }
            else
            {
                myList.Add(myTringle);
                Console.WriteLine("Фигура добавлена!");
            }
        }
        public void funcCircle()
        {
            Circle myCircle = new Circle();
            Console.WriteLine("Введите радиус круга: ");
            myCircle.radius = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя: ");
            myCircle.name = Console.ReadLine();
            if (myCircle.radius < 0)
            {
                myCircle.radius = 0;
                Console.WriteLine("Данные должны быть больше нуля!");
            }
            else
            {
                myList.Add(myCircle);
                Console.WriteLine("Фигура добавлена!");
            }
        }
        public void Print()
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("Фигура {0} имеет площадь {1} и периметр {2}", myList[i].name, myList[i].Square(), myList[i].Perimeter());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DoWhile doWhile = new DoWhile();
            string number = "";
            do
            {
                Console.WriteLine("\nКакую фигуру вы хотите добавить?\n1.Прямоугольник\n2.Квадрат\n3.Треугольник\n4.Круг\n5.Вывести список");
                Console.WriteLine("Для выхода нажмите Q");
                number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        doWhile.funcRectangle();
                        break;
                    case "2":
                        doWhile.funcFoursquare();
                        break;
                    case "3":
                        doWhile.funcTriangle();
                        break;
                    case "4":
                        doWhile.funcCircle();
                        break;
                    case "5":
                        doWhile.Print();
                        break;
                    default: break;
                }
            } while (number != "q");
        }
    }
}
