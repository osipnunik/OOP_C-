using System;
using System.Collections;

namespace ConsoleApp4.task6
{
    class Company
    {
        private ArrayList employees;
        
        public Company(ArrayList employees)
        {
            this.employees = employees;
        }
        public void printEmployees()
        {
            foreach (object o in employees)
            {
                Console.WriteLine(((Employee)o).rang);
            }
        }
        public void sortList()
        {
            employees.Sort();
        }
        public void addEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void removeEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
        
    }
}
