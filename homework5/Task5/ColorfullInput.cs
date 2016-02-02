using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public static class ColorfullInput
    {
        public static void Print(string inputstring , int color)
        {
            switch (color)
            {
                case 1:
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    }
                case 2:
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    }
                case 3:
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    }
                default:
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    }
            }

            Console.WriteLine(inputstring);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
