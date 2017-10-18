using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace CapgeminiTask
{
    public class Customer
    {
        private readonly List<Customer> _customerList = new List<Customer>();

        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected int TelephoneNumber { get; set; }
        protected string Address { get; set; }

        public Customer(string name, string surname, int telephoneNumber, string address)
        {
            Name = name;
            Surname = surname;
            TelephoneNumber = telephoneNumber;
            Address = address;
        }

        public void CreatingXml()
        {
            XDocument xml = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Customer list"),
                new XElement("customers",
                    from customer in _customerList
                    orderby customer.Name
                    select new XElement("customer",
                        new XAttribute("name", customer.Name),
                        new XElement("surname", customer.Surname),
                        new XElement("telephone", customer.TelephoneNumber),
                        new XElement("address", customer.Address)
                    )
                )
            );
            Console.WriteLine(xml);
            MemoryStream mStrm = new MemoryStream(Encoding.UTF8.GetBytes("customers.xml"));
            xml.Save(mStrm);
        }


        public void AddingCustomer()
        {
            Console.WriteLine("Write the Name of customer: ");
            Name = Console.ReadLine();
            Console.WriteLine("Write the Surname of customer: ");
            Surname = Console.ReadLine();
            Console.WriteLine("Write the Tel. number of customer: ");
            TelephoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the Address of customer: ");
            Address = Console.ReadLine();

            _customerList.Add(new Customer(Name, Surname, TelephoneNumber, Address));

            

        }

    }

}
