using System;
using System.Linq;
using System.Xml.Linq;

namespace XUnitTestProject1.task12
{
    class HandBookLinqService
    {
        private const string file = "C:\\Users\\PC\\source\\repos\\ConsoleApp12-13\\ConsoleApp12-13\\task12\\handbook_linq.xml";
        public void CreateXmlFile()
        {
            XDocument xdoc = new XDocument(new XElement("companies",
            new XElement("company",
                new XAttribute("name", "CocaCola"),
                new XElement("owner", "Obama"),
                new XElement("phone", "095784361"),
                new XElement("address", "Alaska"),
                new XElement("activity", "drinks")),
            new XElement("company",
                new XAttribute("name", "Adidas"),
                new XElement("owner", "Cannedy"),
                new XElement("phone", "09578426"),
                new XElement("address", "Oklahoma"),
                new XElement("activity", "dresses"))));
            xdoc.Save(file);
        }

        public void AddCompany(Handbook company)
        {
            XDocument document = XDocument.Load(file);
            document.Element("companies").Add
                 (
                     new XElement
                         ("company",
                new XAttribute("name", company.Name),
                new XElement("owner", company.Owner),
                new XElement("phone", company.Phone),
                new XElement("address", company.Address),
                new XElement("activity", company.Activity)));
            document.Save(file);
        }

        internal Handbook SearchByOwner(string owner)
        {
            XDocument xdoc = XDocument.Load(file);
            var items = from xe in xdoc.Element("companies").Elements("company")
                        where xe.Element("owner").Value == owner
                        select new Handbook
                        {
                            Name = xe.Attribute("name").Value,
                            Owner = xe.Element("owner").Value,
                            Phone = xe.Element("phone").Value,
                            Address = xe.Element("address").Value,
                            Activity = xe.Element("activity").Value,
                        };
            foreach (var item in items)
                return item;
            return null;
        }

        internal Handbook SearchByActivity(string activity)
        {
            XDocument xdoc = XDocument.Load(file);
            var items = from xe in xdoc.Element("companies").Elements("company")
                        where xe.Element("activity").Value == activity
                        select new Handbook
                        {
                            Name = xe.Attribute("name").Value,
                            Owner = xe.Element("owner").Value,
                            Phone = xe.Element("phone").Value,
                            Address = xe.Element("address").Value,
                            Activity = xe.Element("activity").Value,
                        };
            foreach (var item in items)
                return item;
            return null;
        }

        internal Handbook SearchByPhone(string phone)
        {
            XDocument xdoc = XDocument.Load(file);
            var items = from xe in xdoc.Element("companies").Elements("company")
                        where xe.Element("phone").Value == phone
                        select new Handbook
                        {
                            Name = xe.Attribute("name").Value,
                            Owner = xe.Element("owner").Value,
                            Phone = xe.Element("phone").Value,
                            Address = xe.Element("address").Value,
                            Activity = xe.Element("activity").Value,
                        };
            foreach (var item in items)
                return item;
            return null;
        }

        internal void ShowAll()
        {
            XDocument xdoc = XDocument.Load(file);
            var items = from xe in xdoc.Element("companies").Elements("company")
                        select new Handbook
                        {
                            Name = xe.Attribute("name").Value,
                            Owner = xe.Element("owner").Value,
                            Phone = xe.Element("phone").Value,
                            Address = xe.Element("address").Value,
                            Activity = xe.Element("activity").Value,
                        };
            foreach (var item in items)
                Console.WriteLine($"{item.Name} + {item.Owner} +{item.Phone}+{item.Activity}+{item.Address}");
        }
        public Handbook SearchByName(string name)
        {
            XDocument xdoc = XDocument.Load(file);
            var items = from xe in xdoc.Element("companies").Elements("company")
                            where xe.Attribute("name").Value == name
                        select new Handbook
                        {
                            Name = xe.Attribute("name").Value,
                            Owner = xe.Element("owner").Value,
                            Phone = xe.Element("phone").Value,
                            Address = xe.Element("address").Value,
                            Activity = xe.Element("activity").Value,
                        };
            foreach (var item in items)
                return item;
            return null;
        }
    }
}
