using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public class task1
    {
        public void DoSomething()
        {
            Address adress1 = new Address();
            adress1.index = 500;
            adress1.country = "Ukraine";
            adress1.city = "Dnepropetrovsk";
            adress1.street = "Gogol st.";
            adress1.house = 101;
            adress1.apartment = 303;

            Console.WriteLine("Index: {0}",adress1.index);
            Console.WriteLine("Country: {0}", adress1.country);
            Console.WriteLine("City: {0}", adress1.city);
            Console.WriteLine("Street: {0}", adress1.street);
            Console.WriteLine("House: {0}", adress1.house);
            Console.WriteLine("Apartmrnt: {0}", adress1.apartment);
        }
    }

    public class Address
    {
        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }

    }
}
