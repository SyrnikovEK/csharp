using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class PolishNotationConverter
    {
        public static string Convert(string inputstring)
        {
            string outputstring = "";
            Stack<char> stack1 = new Stack<char>();
            inputstring.ToArray();

            for (int i = 0; i < inputstring.Length; i++)
            {
                if ((inputstring[i] == '0') || (inputstring[i] == '1') || (inputstring[i] == '2') || (inputstring[i] == '3') || (inputstring[i] == '4') 
                    || (inputstring[i] == '5') || (inputstring[i] == '6') || (inputstring[i] == '7') || (inputstring[i] == '8') || (inputstring[i] == '9'))
                {
                    outputstring += inputstring[i];
                }
                else
                {
                    switch (inputstring[i])
                    {
                        case '-':
                        case '+':
                            {
                                while ((stack1.Count != 0) && ((stack1.Peek() == '-') || (stack1.Peek() == '+') || (stack1.Peek() == '*') || (stack1.Peek() == '/') || (stack1.Peek() == '^')))
                                {
                                    outputstring += stack1.Pop();
                                }
                                stack1.Push(inputstring[i]);
                                break;
                            }
                        case '*':
                        case '/':
                            {
                                while ((stack1.Count != 0) && ((stack1.Peek() == '*') || (stack1.Peek() == '/') || (stack1.Peek() == '^')))
                                {
                                    outputstring += stack1.Pop();
                                }
                                stack1.Push(inputstring[i]);
                                break;
                            }
                        case '^':
                            {
                                while ((stack1.Count != 0) && (stack1.Peek() == '^'))
                                {
                                    outputstring += stack1.Pop();
                                }
                                stack1.Push(inputstring[i]);
                                break;
                            }
                        case '(':
                            {
                                stack1.Push(inputstring[i]);
                                break;
                            }
                        case ')':
                            {
                                if (stack1.Count != 0)
                                {
                                    while (stack1.Peek() != '(')
                                    {
                                        outputstring += stack1.Pop();
                                    }
                                    stack1.Pop();
                                }
                                else
                                    Console.WriteLine("Error!!!");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Error!!!");
                                break;
                            }
                    }
                }
                if (i == inputstring.Length-1)
                {
                    while (stack1.Count != 0)
                    {
                        outputstring += stack1.Pop();
                    }
                }
            }

            return outputstring;
        }
    }
}
