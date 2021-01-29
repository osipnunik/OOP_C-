using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ConsoleApp12_13.task12
{
    class HandbookService
    {
        private List<Handbook> GetAllHandbooksFromXmlFile()
        {
            List<Handbook> companies = new List<Handbook>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C:\\Users\\PC\\source\\repos\\ConsoleApp12-13\\ConsoleApp12-13\\handbool.xml");
            foreach (var element in xDoc.DocumentElement)
            {
                if (element.GetType().Equals(typeof(System.Xml.XmlElement)))  //Type check first
                {
                    XmlElement xElement = (XmlElement)element;
                    {
                        Handbook company = new Handbook();
                        XmlNode attr = xElement.Attributes.GetNamedItem("name");
                        if (attr != null)
                            company.Name = attr.Value;

                        foreach (XmlNode childnode in xElement.ChildNodes)
                        {
                            if (childnode.Name == "owner")
                                company.Owner = childnode.InnerText;

                            if (childnode.Name == "phone")
                                company.Phone = childnode.InnerText;

                            if (childnode.Name == "address")
                                company.Address = childnode.InnerText;

                            if (childnode.Name == "activity")
                                company.Activity = childnode.InnerText;
                        }
                        companies.Add(company);
                    }
                }
            }
            return companies;
         }

        public Handbook SearchByName(string name)
        {
            foreach (Handbook company in this.GetAllHandbooksFromXmlFile())
            {
                if (company.Name.Equals(name))
                {
                    return company;
                }
            }
            return null;
        }
        public Handbook SearchByOwner(string owner)
        {
            foreach (Handbook company in this.GetAllHandbooksFromXmlFile())
            {
                if (company.Owner.Equals(owner))
                {
                    return company;
                }
            }
            return null;
        }
        public Handbook SearchByPhone(string phone)
        {
            foreach (Handbook company in this.GetAllHandbooksFromXmlFile())
            {
                if (company.Phone.Equals(phone))
                {
                    return company;
                }
            }
            return null;
        }
        public Handbook SearchByActivity(string activity)
        {
            foreach (Handbook company in this.GetAllHandbooksFromXmlFile())
            {
                if (company.Activity.Equals(activity))
                {
                    return company;
                }
            }
            return null;
        }
        public void ShowAllCompanies()
        {
            foreach (Handbook h in this.GetAllHandbooksFromXmlFile())
                Console.WriteLine($"{h.Name} {h.Owner} {h.Phone} {h.Address} {h.Activity}");
        }
    }
}
