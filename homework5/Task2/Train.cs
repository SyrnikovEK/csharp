using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct Train
    {
        string Name;
        int Number;
        DateTime Time;

        public Train(string name , int number , DateTime time)
        {
            Name = name;
            Number = number;
            Time = time;
        }
    }
}
