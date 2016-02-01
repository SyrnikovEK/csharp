using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int number;
            DateTime time;
            Train[] trainarray = new Train[3];
            Console.WriteLine("Input info about 8 trains");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Input Name");
                name = Console.ReadLine();
                Console.WriteLine("Input Number");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Time");
                time = DateTime.Parse(Console.ReadLine());
                //trainarray[i] = new Train(name , number , time);
            }

            for (int i = 0; i <= 3; i++)
            {
                //trainarray[i].ToString();
            }
        }
    }
}
