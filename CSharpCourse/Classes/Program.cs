using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();

            //customer.Id = "1";
            //customer.FirstName = "Cüneyt";
            //customer.LastName = "KILIÇ";
            //customer.City = "Izmir";

            //customer.firstName = "Cnyt";
            //Console.WriteLine(customer.FirstName);
            //Console.ReadLine();

            Customer customer = new Customer
            {
                FirstName = "Cnyt",
                City = "Izmir",
                LastName = "KLC",
                Id = "1"
            };

            Console.WriteLine(customer.City);
            Console.ReadLine();
        }

    }

    class Customer
    {   
        // field
        public string Id;

        // Property
        public string firstName;
        public string FirstName { get { return "Mr." + firstName;  } set { firstName = value; } }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
