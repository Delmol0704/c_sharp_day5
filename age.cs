using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class5
    {
        public static void Main()
        {
            //DateTime today = new DateTime(2021,4,28,3,27,34);
            //Console.WriteLine(String.Format("{0:dd, MM, yyyy, d, hh, mm, ss}",today));
            //Console.ReadLine();

            //DateTime today = DateTime.Now;
            //Console.WriteLine(today.Date);
            //Console.ReadLine();

            DateTime dob = new DateTime(1998, 04, 07);
            DateTime td = DateTime.Now;
            Console.WriteLine("Age in yr : " + (td.Year - dob.Year));
            Console.WriteLine("Age in month : " + (td.Month - dob.Month));
            Console.WriteLine("Age in day : " + (td.Day - dob.Day));
            Console.ReadLine();
        }
    }
}