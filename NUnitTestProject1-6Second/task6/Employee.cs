using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_6Second.task6
{
    class Employee : IComparable
    {
        public int Rang;
        public Employee(int rang)
        {
            this.Rang = rang;
        }

        public int CompareTo(object obj)
        {
            return this.Rang - ((Employee)obj).Rang;
        }

        public static List<Employee> operator +(List<Employee> emps, Employee empl)
        {
            emps.Add(empl);
            return emps;
        }
        public static List<Employee> operator -(List<Employee> emps, Employee empl)
        {
            emps.Remove(empl);
            return emps;
        }
    }
}
