Create a C# program that implements an IVehiculo interface with two methods, 
one for Drive of type void and another for Refuel of type bool that has a parameter of type integer with the amount of gasoline to refuel. 
Then create a Car class with a builder that receives a parameter with the car's starting gasoline amount and implements the Drive and Refuel methods of the car.

The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0. 
The Refuel method will increase the gasoline of the car and return true.

To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program 
and ask the user for an amount of gasoline to refuel, finally execute the Drive method of the car.



using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    interface IVehiculo
    {
        void Drive();
       
        bool Refuel(int amt_gas);
       
    }
    public class Car: IVehiculo
    {
        public int amtOfgas;
        void IVehiculo.Drive()
        {
            if (amtOfgas > 0)
                Console.WriteLine("Car is driving");
        }
        bool IVehiculo.Refuel(int amt)
        {
            amtOfgas = amt;
            return Convert.ToBoolean(amtOfgas);
        }
    }
    class User
    {
        static void Main()
        {
            Car car = new Car();
            car.amtOfgas = 0;
            IVehiculo car1 = car;
            
            Console.WriteLine("Enter amount to refill : ");
            car1.Refuel(Convert.ToInt32(Console.ReadLine()));
            car1.Drive();
            Console.ReadLine();
        }
    }
}