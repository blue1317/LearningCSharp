using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Chris");
            //person.Name = "Chris";
            //person.Introduce("Mike");
            //var p = person.Parse("Chris");
            person.Introduce("Mike");
        }

        
    }

    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
}
