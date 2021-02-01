using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1.task12
{
    class Handbook
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Activity { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " Owner: " + Owner + " Phone: " + Phone + " Address: " + Address +
                " Activity: " + Activity;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || 
                !this.GetType().Equals(obj.GetType()))
            {

                return false;
            }
            else
            {
                Handbook p = (Handbook)obj;
                return (Name.Equals(p.Name)) && (Owner.Equals(p.Owner)) && Phone.Equals(p.Phone)
                    && Address.Equals(p.Address) && Activity.Equals(p.Activity);
            }
        }
    }
}
