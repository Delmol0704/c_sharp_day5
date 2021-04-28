using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class7
    {
        public static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements");
            for(int i=0; i<5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);

            Console.WriteLine(arr[arr.Length - 2]);
        }
    }
}
