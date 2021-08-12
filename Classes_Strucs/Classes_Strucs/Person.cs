using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Strucs
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public string hobby;

        public void Introduction()
        {
            Console.WriteLine("Hi, I'm " + firstName + " " + lastName);
            Console.WriteLine("I'm " + age + " years old, and enjoy " + hobby);
            Console.WriteLine("");
        }
    }
}
