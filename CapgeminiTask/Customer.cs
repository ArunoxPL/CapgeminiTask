using System;
using System.Collections.Generic;
using System.Text;

namespace CapgeminiTask
{
    public class Customer
    {
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public int TelephoneNumber { get; set; }
        //public string Address { get; set; }

        /*public Customer(string name, string surname, int telephoneNumber, string address)
        {
            Name = name;
            Surname = surname;
            TelephoneNumber = telephoneNumber;
            Address = address;
        }*/
        public Customer (string Name, string Surname, int TelephoneNumber, string Address)
        {
            Name = Console.ReadLine();
            Surname = Console.ReadLine();
            TelephoneNumber = Convert.ToInt32(Console.ReadLine());
            Address = Console.ReadLine();

        }

    }

}
