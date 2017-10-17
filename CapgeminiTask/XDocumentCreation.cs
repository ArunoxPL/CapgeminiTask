using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CapgeminiTask
{
    class XDocumentCreation
    {
       /* XDocument xml = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XComment("Customer List"), 
            new XElement("Customers",
                from Customer in CustomerList
                orderby customer.Name
                select new XElement("customer",
                    new XAttribute("name", osoba.Pesel),
                    new XElement("imie", osoba.Imie),
                    new XElement("nazwisko", osoba.Nazwisko),
                    new XElement("wzrost", osoba.Wzrost)
                )
            )
        );

        xml.Save("Osoby.xml");*/
    }
}
