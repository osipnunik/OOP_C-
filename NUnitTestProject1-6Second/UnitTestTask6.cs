using NUnit.Framework;
using NUnitTestProject1_6Second.task6;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnitTestProject1_6Second
{
    class UnitTestTask6
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestAddSortComparingRemooving()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(3));
            employees.Add(new Employee(4));
            Company company = new Company(employees);
            //company.printEmployees();

            Employee e2 = new Employee(5);
            List<Employee> added = employees + e2;
            Assert.AreEqual(3, company.GetEmployees().Count);

            List<Employee> removed = added - e2;
            Assert.AreEqual(2, company.GetEmployees().Count);

            company.sortList();
            Assert.AreEqual(3, company.GetEmployees()[0].Rang);
        }
        [Test]
        public void TestPrinting()
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(3));
            employees.Add(new Employee(4));
            Company company = new Company(employees);
            company.printEmployees();
            string consoleOutput;
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                //there
                company.printEmployees();
                //All console outputs goes here

                consoleOutput = stringWriter.ToString();
                Assert.AreEqual(consoleOutput, "3\r\n4\r\n");

                //
            }
        }
    }
}
