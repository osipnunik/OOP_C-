using System;
using System.Runtime.Serialization;

namespace NUnitTestProject1.task7
{
    [Serializable()]
    class Auto : ISerializable
    {
        private string Name;
        private int Price;
        public Auto(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string getName()
        {
            return Name;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
           info.AddValue("Name", Name);
            info.AddValue("Price", Price);
        }
        public Auto(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Price = (int)info.GetValue("Price", typeof(int));
        }

        public int getPrice()
        {
            return Price;
        }
        public override string ToString()
        {
            return "Name: " + Name + " Price: " + Price;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Auto auto = (Auto)obj;
                return (Name.Equals(auto.Name)) && (Price == auto.Price);
            }
        }
    }
}
