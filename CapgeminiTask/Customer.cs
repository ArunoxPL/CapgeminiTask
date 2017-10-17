using System;
using System.Collections.Generic;
using System.Text;

namespace CapgeminiTask
{
    public struct Customer : ICustomer
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int TelephoneNumber { get; set; }
        private string Address { get; set; }

        public void AddCustomer()
        {
            Console.WriteLine("Write the Name of customer: ");
            Name = Console.ReadLine();
            Console.WriteLine("Write the Surname of customer: ");
            Surname = Console.ReadLine();
            Console.WriteLine("Write the Tel. number of customer: ");
            TelephoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Address of customer: ");
            Address = Console.ReadLine();
        }



    }

}
