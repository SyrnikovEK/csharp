using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public class Task2
    {
        public void DoSomething()
        {
            Console.WriteLine("Input lengths of 2 sides");
            Rectangle rect1 = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Area is: {0}", rect1.Area);
            Console.WriteLine("Perimeter is: {0}", rect1.Perimeter);
        }
    }

    public class Rectangle
    {
        private double side1;
        private double side2;


        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                side1 = value;
            }
        }
        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                side2 = value;
            }
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }

        public Rectangle ()
        {
            side1 = 1;
            side2 = 1;
        }
        public Rectangle (double side1 , double side2)
        {
            this.side1 = side1;
            this.side2 = side2; 
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return side1 * 2 + side2 * 2;
        }
    }
}
