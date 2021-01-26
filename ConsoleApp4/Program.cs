using ConsoleApp4.task6;
using System;
using System.Collections;
using System.Diagnostics;

namespace ConsoleApp4
{
    class Program
    {
        class Counter
        {
            private int value = 0;
            private const int maxVal = 100;
            private const int minVal = 0;
            public void setValue(int value)
            {
                if (value <= maxVal && value >= minVal)
                {
                    this.value = value;
                }
                else {
                    Console.WriteLine("value beyond the range");
                }
            }
            public void incrementOn1()
            {
                if(value==maxVal){
                    value = minVal;
                    return;
                }
                value++;
            }
            public void setMax()
            {
                value = maxVal;
            }
            public void setMin()
            {
                value = minVal;
            }

            internal int getValue()
            {
                return value;
            }
        }
        static void Main(string[] args)
        {
            //Task1("abba");
            //Task2("africa", "a", "o");
            //Task3(20);
            //Task4(); 
            Task5();
            //Task6();
        }

        private static void Task6()
        {
            ArrayList employees = new ArrayList();
            employees.Add(new Employee(3));
            employees.Add(new Employee(4));
            Company company = new Company(employees);
            company.printEmployees();

            Employee e2 = new Employee(5);
            ArrayList added = employees + e2;
            company.printEmployees();
            ArrayList removed = added - e2;

        }

        private static void Task5()
        {
            Poligon poligon = new Rhombus();
            poligon.draw();
        }
        private static void Task4()
        {
            Counter counter = new Counter();
            counter.setMax();
            counter.incrementOn1();
            Console.WriteLine(counter.getValue());
            counter.setValue(3);
            counter.incrementOn1();
            Console.WriteLine(counter.getValue());
        }

        private static void Task3(int N)
        {
            int[] arr = new int[N];
            for(int i = 0; i < arr.Length; i++)
            {
                Random r = new Random();
                arr[i] = r.Next(-500, 500);
                Array.Sort(arr);
            }
        }

        private static string Task2(string text, string searched, string to)
        {
            if (text.Contains(searched))
            {
                string newString = text.Replace(searched, to);
                Console.WriteLine(newString);
                return newString;
            }
            return text;
        }

        private static void Task1(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string new1 = new string(charArray);
            Console.WriteLine(input + " " + new1);
            Debug.Assert(new1.Equals(input));

        }
    }
}
