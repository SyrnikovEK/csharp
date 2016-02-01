using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class PolishNotationCalculator
    {
        public static double Calculate(string inputstring)
        {
            double ans = 0;
            double var1 , var2;
            Stack<char> stack1 = new Stack<char>();
            Stack<double> stack2 = new Stack<double>();
            inputstring.ToArray();

            for (int i = inputstring.Length - 1; i >= 0; i--)
            {
                stack1.Push(inputstring[i]);
            }

            while (stack1.Count != 0)
            {
                switch (stack1.Peek())
                {
                    case '0':
                        {
                            stack2.Push(0);
                            stack1.Pop();
                            break;
                        }
                    case '1':
                        {
                            stack2.Push(1);
                            stack1.Pop();
                            break;
                        }
                    case '2':
                        {
                            stack2.Push(2);
                            stack1.Pop();
                            break;
                        }
                    case '3':
                        {
                            stack2.Push(3);
                            stack1.Pop();
                            break;
                        }
                    case '4':
                        {
                            stack2.Push(4);
                            stack1.Pop();
                            break;
                        }
                    case '5':
                        {
                            stack2.Push(5);
                            stack1.Pop();
                            break;
                        }
                    case '6':
                        {
                            stack2.Push(6);
                            stack1.Pop();
                            break;
                        }
                    case '7':
                        {
                            stack2.Push(7);
                            stack1.Pop();
                            break;
                        }
                    case '8':
                        {
                            stack2.Push(8);
                            stack1.Pop();
                            break;
                        }
                    case '9':
                        {
                            stack2.Push(9);
                            stack1.Pop();
                            break;
                        }
                    case '+':
                        {
                            var1 = stack2.Pop();
                            var2 = stack2.Pop();
                            stack2.Push(var1 + var2); 
                            stack1.Pop();
                            break;
                        }
                    case '-':
                        {
                            var1 = stack2.Pop();
                            var2 = stack2.Pop();
                            stack2.Push(var2 - var1);
                            stack1.Pop();
                            break;
                        }
                    case '*':
                        {
                            var1 = stack2.Pop();
                            var2 = stack2.Pop();
                            stack2.Push(var1 * var2);
                            stack1.Pop();
                            break;
                        }
                    case '/':
                        {
                            var1 = stack2.Pop();
                            var2 = stack2.Pop();
                            stack2.Push(var2 / var1);
                            stack1.Pop();
                            break;
                        }
                    case '^':
                        {
                            var1 = stack2.Pop();
                            var2 = stack2.Pop();
                            stack2.Push(Math.Pow(var2 , var1));
                            stack1.Pop();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            ans = stack2.Pop();
            return ans;
        }
    }
}
