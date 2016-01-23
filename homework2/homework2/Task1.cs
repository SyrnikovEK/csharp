using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Task1
    {
        public void DoSomething()
        {
            Printer p1 = new Printer();
            p1.Print("aaa");

            Printer p2 = new RedPrinter();
            p2.Print("bbb");

            GreenPrinter p3 = new GreenPrinter();
            p3.Print("ccc");

            BluePrinter p4 = new BluePrinter();
            (p4 as Printer).Print("ddd");
            Console.ReadKey();
        }

        public class Printer
        {
            public virtual void Print(string value)
            {
                Console.WriteLine(value);
            }
        }

        public class RedPrinter : Printer
        {
            public override void Print(string value)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                base.Print(value);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public class GreenPrinter : Printer
        {
            public override void Print(string value)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                base.Print(value);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public class BluePrinter : Printer
        {
            public override void Print(string value)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                base.Print(value);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}

