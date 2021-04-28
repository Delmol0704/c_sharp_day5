Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. 
To do this, first create a Person class that has a Name property of type string, 
a constructor that receives the name as a parameter, 
a destructor that assigns the name to empty and overwrites the ToString () method.

End the program by reading the people and executing the ToString () method on screen.


using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Person
    {
        private string Name;
        public Person(string name)
        {
            Name = name;
        }
        ~Person()
        {
            Name = string.Empty;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        
        }
    class user
    {
        public static void Main()
        {
            Person[] persons = new Person[3];
            Console.WriteLine("Enter 3 names: ");
            for (int i = 0; i < persons.Length; i++)
            {
                Person person = new Person(Console.ReadLine());
                persons[i] = person;
            }
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
            Console.ReadLine();

        }
    }
        
    
}