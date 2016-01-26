using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Task3
    {
        public void DoSomething()
        {
            Car car1 = new Car();
            Plane plane1 = new Plane();
            Ship ship1 = new Ship();
            Console.WriteLine("Car:");
            car1.Info();
            Console.WriteLine("Plane:");
            plane1.Info();
            Console.WriteLine("Ship:");
            ship1.Info();
            Console.ReadKey();
        }

        public class Vehicle
        {
            private int x;
            private int y;
            private double price; //mb decimal?
            private double speed;
            private int year; //mb date?

            public Vehicle()
            {
                x = 1;
                y = 1;
                price = 1000;
                speed = 0;
                year = 2000;
            }

            public int X
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }
            }
            public int Y
            {
                get
                {
                    return y;
                }
                set
                {
                    y = value;
                }
            }
            public double Price
            {
                get
                {
                    return price;
                }
                set
                {
                    price = value;
                }
            }
            public double Speed
            {
                get
                {
                    return speed;
                }
                set
                {
                    speed = value;
                }
            }

            public int Year
            {
                get
                {
                    return year;
                }
            }

            public virtual void Info()
            {
                Console.WriteLine("Position: X = {0} Y = {1}",x,y);
                Console.WriteLine("Speed = " + speed);
                Console.WriteLine("Year = " + year);
            }

        }

        public class Plane : Vehicle
        {
            private double hight;
            private int capacity;

            public Plane()
            {
                hight = 0;
                capacity = 100;
            }

            public double Hight
            {
                get
                {
                    return hight;
                }
                set
                {
                    hight = value;
                }
            }
            public int Capacity
            {
                get
                {
                    return capacity;
                }
            }

            public override void Info()
            {
                base.Info();
                Console.WriteLine("Hight = " + hight);
                Console.WriteLine("Capacity = " + capacity);
            }
        }

        public class Car : Vehicle
        {
            private int numberofdoors;

            public Car()
            {
                numberofdoors = 4;
            }

            public int NumberOfDoors
            {
                get
                {
                    return numberofdoors;
                }
            }

            public override void Info()
            {
                base.Info();
                Console.WriteLine("Number of doors = " + numberofdoors);
            }
        }

        public class Ship : Vehicle
        {
            private int capacity;
            private string port;

            public Ship()
            {
                capacity = 200;
                port = "qqq";
            }

            public int Capacity
            {
                get
                {
                    return capacity;
                }
            }
            public string Port
            {
                get
                {
                    return port;
                }
            }

            public override void Info()
            {
                base.Info();
                Console.WriteLine("Capacity = " + capacity);
                Console.WriteLine("Port: " + port);
            }
        }
    }
}