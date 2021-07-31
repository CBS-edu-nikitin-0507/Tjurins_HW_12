using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Address adr = new Address();
            Console.WriteLine("Enter your postal info");
            
            Console.Write("Postal index:");
            adr.Index = Console.ReadLine();
            Console.Write("Country:");
            adr.Country = Console.ReadLine();
            Console.Write("City:");
            adr.City = Console.ReadLine();
            Console.Write("Street:");
            adr.Street = Console.ReadLine();
            Console.Write("House:");
            adr.House = Console.ReadLine();
            Console.Write("Apartment:");
            adr.Apartment = Console.ReadLine();

            Console.WriteLine(new string('-',30));
            Console.WriteLine("Here is your address: ");
            adr.PrintAddr();
            //Console.Write(adr.Index+" ");
            //Console.Write(adr.Country + " ");
            //Console.WriteLine(adr.City);
            //Console.Write(adr.Street);
            //Console.Write(adr.House + "-");
            //Console.Write(adr.Apartment);

            Console.ReadLine();
        }
    }
}
