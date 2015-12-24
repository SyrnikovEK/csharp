using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public class Task5
    {
        public void DoSomething()
        {
            User user1 = new User();
            Console.WriteLine("Input Login");
            user1.Login = Console.ReadLine();
            Console.WriteLine("Input Name");
            user1.Name = Console.ReadLine();
            Console.WriteLine("Input Second Name");
            user1.Sname = Console.ReadLine();
            Console.WriteLine("Input Age");
            user1.Age = int.Parse(Console.ReadLine());

            user1.Show();
        }

        public class User
        {
            private string login;
            private string name;
            private string sname;
            private int age;
            private DateTime date;

            public string Login
            {
                get
                {
                    return login;
                }
                set
                {
                    login = value;
                }
            }
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public string Sname
            {
                get
                {
                    return sname;
                }
                set
                {
                    sname = value;
                }
            }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }
            public DateTime Date
            {
                get
                {
                    return date;
                }
            }

            public User(string login = "", string name = "", string sname = "", int age = 18)
            {
                this.login = login;
                this.name = name;
                this.sname = sname;
                this.age = age;
                this.date = DateTime.Now.Date;
            }

            public void Show()
            {
                Console.WriteLine(login);
                Console.WriteLine(name);
                Console.WriteLine(sname);
                Console.WriteLine(age);
                Console.WriteLine(date);
            }
        }
    }
}
