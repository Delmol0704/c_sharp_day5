using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public struct Employee
    {
        public string EmployeeName;
        public int EmployeeId;
        public Salary sal;
       
    }
    public struct Salary
    {
        public int monthly;
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter no. of employees : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Employee[] emp = new Employee[n];
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("enter employee name : ");
                emp[i].EmployeeName = Console.ReadLine();
                Console.WriteLine("enter employee id : ");
                emp[i].EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employee salary : ");
                emp[i].sal.monthly = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
            }
        }
    }
}
