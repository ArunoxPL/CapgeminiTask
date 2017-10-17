using System;
using System.Collections.Generic;
using System.Text;

namespace CapgeminiTask
{
    public class Worker
    {
        //Customer customer = new Customer(string, string, int, string);
        List<Customer> customer = new List<Customer>();
        //Menu
        public Worker()
        {
            Console.WriteLine("Welcome in Menu, what do you want to do? \n Add new Customer press 1 \n Update Customer press 2 \n Delete Customer press 3 \n Exit press 4");
        }

        public void Menu()
        {
            int? result = null;
            
            try
            {
                result = Convert.ToInt16(Console.ReadLine());
               
                switch (result)
                {
                    case 1:
                    {
                        customer.Add(new Customer()) ;
                        Console.WriteLine(" Add menu works");
                    }
                        break;
                    case 2:
                        Console.WriteLine(" Delete menu works");
                        break;
                    case 3:
                        Console.WriteLine(" Update menu works");
                        break;
                    case 4:
                        Console.WriteLine(" Exit menu works");
                        break;
                    default:
                        Console.WriteLine(" Wrong Parameter Works");
                        break;
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Something went wrong");
            }

        }

    }
}
