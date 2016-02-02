using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct Train
    {
        public string Name;
        public int Number;
        public string Time;  //kostyl'

        public Train(string name , int number , string time)
        {
            Name = name;
            Number = number;
            Time = time;
        }
    }
}
