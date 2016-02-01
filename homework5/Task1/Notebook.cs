using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct Notebook
    {
        string Name;
        string Manufacturer;
        double Price;
        public Notebook(string name , string manufacturer , int price)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine("Name: {0}, Manufacturer: {1}, Price: {2}" , Name , Manufacturer , Price);
        }
    }
}
