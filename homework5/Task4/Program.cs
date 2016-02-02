using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            int month;
            int year;
            int numberofdays;
            DateTime today = new DateTime();
            
            today = DateTime.Now;
            Console.WriteLine("Today is {0}/{1}/{2}" , today.Day , today.Month , today.Year);
            Console.WriteLine("Input date of your birth");
            Console.WriteLine("Input year");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input nuber of month");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Input day");
            day = int.Parse(Console.ReadLine());

            DateTime birth = new DateTime(year , month , day);

            if ((birth.Month > today.Month) && (birth.Day > today.Day))
            {
                TimeSpan ts = new DateTime(today.Year , birth.Month , birth.Day) - today;

                numberofdays = ts.Days;

                System.Console.WriteLine("To your birthday: {0} days", numberofdays);
            }
            else
            {
                TimeSpan ts = new DateTime(today.Year + 1, birth.Month, birth.Day) - today;

                numberofdays = ts.Days;

                System.Console.WriteLine("To your birthday: {0} days", numberofdays);
            }

            Console.ReadKey();
        }
    }
}
