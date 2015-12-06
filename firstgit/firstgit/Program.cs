using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstgit
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------------------------------------
            /*
            Напишите консольное приложение которое выводит на экран Ваши ФИО в формате
            +-------------------------------+
            |Фамилия Имя Очество|
            +-------------------------------+
            */

            /*
            System.Console.WriteLine("+-------------------------------+");
            System.Console.WriteLine("|Сырников Евгений Константинович|");
            System.Console.WriteLine("+-------------------------------+");
            System.Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------
            /*
            1.	Пользователь вводит два числа. Вывести на экран большее
            */

            /*
            int a,b;
            int sup;
            Console.WriteLine("Write two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sup = a > b ? a : b;
            Console.WriteLine(sup + " is bigger");
            System.Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------
            /*
            2.	Пользователь вводит слово «мяу» или слово «гав» если слово введенное пользователем «мяу» вывести на экран «Покорми кота» иначе «Погуляй с собакой»
            */

            /*
            string s;
            Console.WriteLine("Say something, animal");
            s = Console.ReadLine();
            switch (s)
            {
                case "myau":
                    {
                        Console.WriteLine("feed the cat");
                        break;
                    }
                case "gav":
                    {
                        Console.WriteLine("walk the dog");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("wrong!");
                        break;
                    }
            }
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------
            /*
            3.	Пользователь вводит номер месяца если месяц 1,2,12 вывести на экран «Зима»; 3,4,5 – «Весна»; 6-8 – «Лето»; 9-11 – «Осень». 
            В любом другом случае «На этой планете такого месяца нет»
            */

            /*
            int m;
            m = int.Parse(Console.ReadLine());
            if (m > 12 || m < 1)
            {
                Console.WriteLine("wrong month");
            }
            else
            {
                if (m == 1 || m == 2 || m == 12)
                    Console.WriteLine("winter");
                if (m == 3 || m == 4 || m == 5)
                    Console.WriteLine("spring");
                if (m == 6 || m == 7 || m == 8)
                    Console.WriteLine("summer");
                if (m == 9 || m == 10 || m == 11)
                    Console.WriteLine("autumn");
            }
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------
            /*
            4.	Пользователь вводит число 1 или 0 с помощью одной строки кода вывести на экран «Хорошо» если пользователь ввел 1 или «Плохо» если пользователь ввел 0
            */

            /*
            int q;
            Console.WriteLine("enter 1 or 0");
            q = int.Parse(Console.ReadLine());          
            Console.WriteLine(q == 1 ? "good" : "bad");
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------
            /*
            5.	Вывести название дня недели по его номеру (1 - понедельник, 7 - воскресенье) 
            */

            /*
            int day;
            Console.WriteLine("enter number of day");
            day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    {
                        Console.WriteLine("monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("sundey");
                        break;
                    }
                default:
                    break;
            }
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------
            /*
            6.	Служба такси заказала вам программу, которая спрашивает количество километров и количество минут простоя, а дальше считает так: 
            первые 5 километров (или до 5 км) 20 гривен, каждый следующий километр 3 гривны, плюс простой 1 грн за 1 минуту. 
            Программа должна посчитать и сказать общую сумму оплаты за поездку. 
            */

            /*
            int s, t , res;
            Console.WriteLine("input length");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("input time");
            t = int.Parse(Console.ReadLine());
            if (s <= 5)
                res = 20 + t;
            else
                res = 20 + (s - 5) * 3 + t;
            
            Console.WriteLine(res + "uah");
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------
            /*
            7.	Дано натуральное число. Выяснить, является ли оно простым, т.е. делится только на 1 и на само себя. 
            */

            /*
            int number;
            bool smpl;
            smpl = true;
            Console.WriteLine("inpun N");
            number = int.Parse(Console.ReadLine());
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    smpl = false;
            }
            if (smpl)
                Console.WriteLine("N is simple");
            else
                Console.WriteLine("N is not simple");
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------
            /*
            8.	Вы организатор лотереи. Пользователь вводит ставку. Вы бросаете 12-гранный кубик. 
            Если выпадают значения от 1 до 5, пользователь проиграл. Если выпадают значения от 6 до 8, пользователь получает свою ставку обратно. 
            Если выпало от 9 до 11, пользователь получает двойную ставку, а если выпало 12 - ставку умноженную на 10. 
            После окончания игры покажите пользователю, сколько он выиграл. 
            */

            /*
            int bet , dice;
            Random r = new Random();
            while (true)
            {
                Console.WriteLine("inpun your bet");
                bet = int.Parse(Console.ReadLine());
                dice = r.Next(1, 13);
                Console.WriteLine("dice: " + dice);
                if (dice < 6)
                    Console.WriteLine("you lose");
                if ((dice > 5) && (dice < 9))
                    Console.WriteLine("you win " + bet);
                if ((dice > 8) && (dice < 12))
                    Console.WriteLine("you win " + bet * 2);
                if (dice == 12)
                    Console.WriteLine("you win " + bet * 10);
                //Console.ReadKey();
            }
            */
            //----------------------------------------------------------------------------------------------------------------
            /*
            9.	Сделать программу перевода валют. Вводится сумма, потом выбирается вид валюты – гривны или доллары или евро, программа переводит в две другие валюты. 
            Текущий курс валюты считать известным.
            */

            /*
            float cash;
            string curr;
            Console.WriteLine("inpun summ");
            cash = float.Parse(Console.ReadLine());
            Console.WriteLine("inpun currency");
            curr = Console.ReadLine();
            if (curr == "uah")
            {
                Console.WriteLine(cash * 1/3 +" eur");
                Console.WriteLine(cash * 1/2 +" usd");
            }
            if (curr == "eur")
            {
                Console.WriteLine(cash * 3 +" uah");
                Console.WriteLine(cash * 3/2 +" usd");
            }
            if (curr == "usd")
            {
                Console.WriteLine(cash * 2 +" uah");
                Console.WriteLine(cash * 2/3 +" eur");
            }
            Console.ReadKey();
            */
            //----------------------------------------------------------------------------------------------------------------
        }
    }
}
