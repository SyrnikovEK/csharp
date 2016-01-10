using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Task7
    {
        public void DoSomething()
        {
            Console.WriteLine("Inpun name and second name");
            Employee emp1 = new Employee(Console.ReadLine() , Console.ReadLine());
            emp1.Show();
            Console.WriteLine();
            emp1.Increase();
            emp1.Show();
        }

        public enum Post { Junior , Middle , Senior };
        public class Employee
        {
            private string name;
            private string sname;

            private Post EmpPost;

            public Employee(string name , string sname)
            {
                this.name = name;
                this.sname = sname;
                EmpPost = Post.Junior;
            }

            public void Increase()
            {
                EmpPost++;
            }

            public double CalculateSallary(double bonuses = 0)
            {
                double sallary = 0;
                switch (EmpPost)
                {
                    case Post.Junior:
                        {
                            sallary = 500 + bonuses;
                            break;
                        }
                    case Post.Middle:
                        {
                            sallary = 1200 + bonuses;
                            break;
                        }
                    case Post.Senior:
                        {
                            sallary = 2100 + bonuses;
                            break;
                        }
                    default:
                        break;
                }
                return sallary;
            }

            public double CalculateTaxes()
            {
                return CalculateSallary() * 0.1;
            }

            public void Show()
            {
                Console.WriteLine("Name " + name);
                Console.WriteLine("Second name " + sname);
                Console.WriteLine("Post " + EmpPost.ToString());
                Console.WriteLine("Sallary " + CalculateSallary());
                Console.WriteLine("Taxes " + CalculateTaxes());
            }
        }
    }
}
