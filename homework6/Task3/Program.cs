using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public delegate double DelegateCollector(MyDelegate[] delegateArr);
        public delegate int MyDelegate();
        static void Main(string[] args)
        {
            MyDelegate myDelegate1 = () => { Random r1 = new Random(); return r1.Next(10); };
            MyDelegate myDelegate2 = () => { Random r1 = new Random(); return r1.Next(50); };
            MyDelegate myDelegate3 = () => { Random r1 = new Random(); return r1.Next(100); };
            MyDelegate[] arr = { myDelegate1, myDelegate2, myDelegate3 };
            DelegateCollector delegateCollector = (MyDelegate[] delegateArr) => 
            {
                double sum = 0;
                int i;
                for (i = 0; i < delegateArr.Length; i++)
                {
                    sum += delegateArr[i].Invoke();
                }
                return sum / i;
            };

            foreach (MyDelegate a in arr)
            {
                Console.WriteLine(a.Invoke());
            }

            Console.WriteLine(delegateCollector(arr));

            Console.ReadKey();
        }
    }
}
