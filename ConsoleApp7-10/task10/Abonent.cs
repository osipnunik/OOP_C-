using System;
using System.Runtime.Serialization;

namespace ConsoleApp7_10.task10
{
    [Serializable()]
    class Abonent : IComparable<Abonent>, ISerializable
    {
        public Abonent() { }
        public Abonent(string number, string surname)
        {
            this.Number = number;
            this.Surname = surname;
        }
        public string Number { get; set; }
        public string Surname { get; set; }

        public int CompareTo(Abonent other)
        {
            return Surname.CompareTo(other.Surname);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Number", Number);
            info.AddValue("Surname", Surname);
        }
        public Abonent(SerializationInfo info, StreamingContext context)
        {
            Number = (string)info.GetValue("Number", typeof(string));
            Surname = (string)info.GetValue("Surname", typeof(string));
        }
        
        public override string ToString()
        {
            return "Number: " + Number + " Surname: " + Surname;
        }
    }
}
