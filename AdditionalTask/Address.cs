using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        //public Address()
        //{
        //    this.Index = "N/A";
        //    this.Country = "N/A";
        //    this.City = "N/A";
        //    this.Street = "N/A";
        //    this.House = "N/A";
        //    this.Apartment = "N/A";
        //}

        public void PrintAddr()
        {
            Console.Write(Index + " ");
            Console.Write(Country + " ");
            Console.WriteLine(City);
            Console.Write(Street + " ");
            Console.Write(House + "-");
            Console.Write(Apartment);
        }
    }
}
