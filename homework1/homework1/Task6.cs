using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public class Task6
    {
        public void DoSomething()
        {
            double usd, eur, rub;
            string m = "";
            double cash;

            Console.WriteLine("Input USD rate");
            usd = double.Parse(Console.ReadLine());
            Console.WriteLine("Input EUR rate");
            eur = double.Parse(Console.ReadLine());
            Console.WriteLine("Input RUB rate");
            rub = double.Parse(Console.ReadLine());

            Converter Conv = new Converter(usd , eur , rub);

            Console.WriteLine("0 - Convert into grn");
            Console.WriteLine("1 - Convert from grn");
            m = Console.ReadLine();
            switch (m)
            {
                case "0":
                    {
                        Console.WriteLine("Inpun cash");
                        cash = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input currency");
                        switch (Console.ReadLine())
                        {
                            case "usd":
                                {
                                    Console.WriteLine(Conv.ConvertInGrn(ExchRate.usd, cash));
                                    break;
                                }
                            case "eur":
                                {
                                    Console.WriteLine(Conv.ConvertInGrn(ExchRate.eur, cash));
                                    break;
                                }
                            case "rub":
                                {
                                    Console.WriteLine(Conv.ConvertInGrn(ExchRate.rub, cash));
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Error!");
                                    break;
                                }
                        }
                        break;
                    }
                case "1":
                    {
                        Console.WriteLine("Inpun cash");
                        cash = double.Parse(Console.ReadLine());
                        Console.WriteLine("Input currency");
                        switch (Console.ReadLine())
                        {
                            case "usd":
                                {
                                    Console.WriteLine(Conv.ConvertFromGrn(ExchRate.usd, cash));
                                    break;
                                }
                            case "eur":
                                {
                                    Console.WriteLine(Conv.ConvertFromGrn(ExchRate.eur, cash));
                                    break;
                                }
                            case "rub":
                                {
                                    Console.WriteLine(Conv.ConvertFromGrn(ExchRate.rub, cash));
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Error!");
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }
            }
        }

        public enum ExchRate
        {
            grn , usd , eur , rub
        }
        public class Converter
        {
            private double usd;
            private double eur;
            private double rub;

            public Converter (double usd , double eur , double rub)
            {
                this.usd = usd;
                this.eur = eur;
                this.rub = rub;
            }

            public double ConvertFromGrn(ExchRate s , double grn)
            {
                double Sum = 0;
                switch (s)
                {
                    case ExchRate.usd:
                        {
                            Sum = grn / this.usd;
                            break;
                        }
                    case ExchRate.eur:
                        {
                            Sum = grn / this.eur;
                            break;
                        }
                    case ExchRate.rub:
                        {
                            Sum = grn / this.rub;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                        
                }
                return Sum;
            }

            public double ConvertInGrn(ExchRate s, double cash)
            {
                double Sum = 0;
                switch (s)
                {
                    case ExchRate.usd:
                        {
                            Sum = cash * this.usd;
                            break;
                        }
                    case ExchRate.eur:
                        {
                            Sum = cash * this.eur;
                            break;
                        }
                    case ExchRate.rub:
                        {
                            Sum = cash * this.rub;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error!");
                            break;
                        }

                }
                return Sum;
            }
        }
    }
}
