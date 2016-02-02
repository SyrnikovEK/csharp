using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            string color;
            Console.WriteLine("Input string");
            str = Console.ReadLine();
            Console.WriteLine("Input color");
            color = Console.ReadLine();
            color.ToLower();

            switch (color)
            {
                case "red":
                    {
                        ColorfullInput.Print(str, (int)Color.Red);
                        break;
                    }
                case "green":
                    {
                        ColorfullInput.Print(str, (int)Color.Green);
                        break;
                    }
                case "blue":
                    {
                        ColorfullInput.Print(str, (int)Color.Blue);
                        break;
                    }
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
