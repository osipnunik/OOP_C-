using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1_6Second.task6
{
    class Company
    {
        private List<Employee> Employees;

        public Company(List<Employee> employees)
        {
            this.Employees = employees;
        }
        public void printEmployees()
        {
            foreach (object o in Employees)
            {
                Console.WriteLine(((Employee)o).Rang);
            }
        }
        public void sortList()
        {
            Employees.Sort();
        }
        public void addEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void removeEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
        public List<Employee> GetEmployees()
        {
            return Employees;
        }
    }
}
