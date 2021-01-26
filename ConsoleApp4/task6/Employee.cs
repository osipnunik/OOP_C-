using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.task6
{
    class Employee
    {
        public int rang;
        public Employee(int rang)
        {
            this.rang = rang;
        }
        public static ArrayList operator +(ArrayList emps, Employee empl)
        {
            emps.Add(empl);
            return emps;
        }
        public static ArrayList operator -(ArrayList emps, Employee empl)
        {
            emps.Remove(empl);
            return emps;
        }
    }
}
