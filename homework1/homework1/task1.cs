using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public class Task1
    {
        public void DoSomething()
        {
            Address adress1 = new Address();
            adress1.Index = 500;
            adress1.Country = "Ukraine";
            adress1.City = "Dnepropetrovsk";
            adress1.Street = "Gogol st.";
            adress1.House = 101;
            adress1.Apartment = 303;

            Console.WriteLine("Index: {0}",adress1.Index);
            Console.WriteLine("Country: {0}", adress1.Country);
            Console.WriteLine("City: {0}", adress1.City);
            Console.WriteLine("Street: {0}", adress1.Street);
            Console.WriteLine("House: {0}", adress1.House);
            Console.WriteLine("Apartmrnt: {0}", adress1.Apartment);
        }
    }

    public class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;


        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }
}
