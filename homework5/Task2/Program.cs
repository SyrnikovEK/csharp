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
            const int ArrayCount = 3;
            string name;
            int number;
            string time;
            Train[] trainarray = new Train[ArrayCount];
            Console.WriteLine("Input info about {0} trains", trainarray.Length);
            for (int i = 0; i <= trainarray.Length - 1; i++)
            {
                Console.WriteLine("Input Name");
                name = Console.ReadLine();
                Console.WriteLine("Input Number");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Time");
                time = Console.ReadLine();
                trainarray[i] = new Train(name , number , time);
            }

            Train tmp = new Train();
            for (int i = 0; i < trainarray.Length - 1; i++)
            {
                for (int j = 0; j < trainarray.Length - i - 1; j++)
                {
                    if (trainarray[j].Number > trainarray[j + 1].Number)
                    {
                        tmp = trainarray[j];
                        trainarray[j] = trainarray[j + 1];
                        trainarray[j + 1] = tmp;
                    }
                }
            }

            for (int i = 0; i < trainarray.Length; i++)
            {
                Console.WriteLine("Name: {0}, Number: {1}, Time: {2}" , trainarray[i].Name , trainarray[i].Number , trainarray[i].Time);
            }

            int numb;
            bool find = false;
            Console.WriteLine("Input Number:");
            numb = int.Parse(Console.ReadLine());
            for (int i = 0; i < trainarray.Length - 1; i++)
            {
                if (trainarray[i].Number == numb)
                {
                    numb = i;
                    find = true;
                    break;
                }
            }

            if (find)
            {
                Console.WriteLine("Name: {0}, Number: {1}, Time: {2}", trainarray[numb].Name, trainarray[numb].Number, trainarray[numb].Time);
            }
            else
            {
                Console.WriteLine("There's no trains of this number");
            }

            Console.ReadKey();
        }
    }
}
