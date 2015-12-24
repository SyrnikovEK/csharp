using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public class Task4
    {
        public void DoSomething()
        {
            Figure f1, f2, f3;
            Point p1, p2, p3, p4, p5;
            p1 = new Point(0, 0);
            p2 = new Point(0, 2);
            p3 = new Point(2, 2);
            p4 = new Point(3, 1);
            p5 = new Point(2, 0);

            f1 = new Figure(p1, p2, p3);
            f2 = new Figure(p1, p2, p3, p4);
            f3 = new Figure(p1, p2, p3, p4, p5);

            f1.Show();
            f2.Show();
            f3.Show();
        }

        public class Point
        {
            private int x;
            private int y;
            private string name;

            public int X
            {
                get
                {
                    return x;
                }
            }
            public int Y
            {
                get
                {
                    return y;
                }
            }
            public string Name
            {
                get
                {
                    return name;
                }
            }

            public Point(int x = 0, int y = 0, string name = "")
            {
                this.x = x;
                this.y = y;
                this.name = name;
            }
        }

        public class Figure
        {
            private Point p1, p2, p3, p4, p5;
            private string name;
            private double perimeter;
            public string Name
            {
                get
                {
                    return name;
                }
            }
            public double Perimeter
            {
                get
                {
                    return perimeter;
                }
            }

            public Figure(Point p1, Point p2, Point p3)
            {
                this.p1 = new Point(p1.X, p1.Y, p1.Name);
                this.p2 = new Point(p2.X, p2.Y, p3.Name);
                this.p3 = new Point(p3.X, p3.Y, p3.Name);
                name = "Triangle";
            }

            public Figure(Point p1, Point p2, Point p3, Point p4)
            {
                p1 = new Point(p1.X, p1.Y, p1.Name);
                p2 = new Point(p2.X, p2.Y, p3.Name);
                p3 = new Point(p3.X, p3.Y, p3.Name);
                p4 = new Point(p4.X, p4.Y, p4.Name);
                name = "Rectangle";
            }

            public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
            {
                p1 = new Point(p1.X, p1.Y, p1.Name);
                p2 = new Point(p2.X, p2.Y, p3.Name);
                p3 = new Point(p3.X, p3.Y, p3.Name);
                p4 = new Point(p4.X, p4.Y, p4.Name);
                p5 = new Point(p5.X, p5.Y, p5.Name);
                name = "Pentagon";
            }

            //запутался с экземплярами
            public double LengthSide(Point p1 , Point p2)
            {
                return Math.Sqrt(Math.Pow((p2.X - p1.X) , 2) - Math.Pow((p2.Y - p1.Y), 2));
            }
     
            public void PerimeterCalculator()
            {
                if (name == "Triangle")
                {
                    perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p1);
                }
                if (name == "Rectangle")
                {
                    perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p1);
                }
                if (name == "Pentagon")
                {
                    perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p5, p1);
                }
            }

            public void Show()
            {
                PerimeterCalculator();
                Console.WriteLine("Figure : {0} , Perimeter: {1}", Name, Perimeter);
            }
        }
    }
}
