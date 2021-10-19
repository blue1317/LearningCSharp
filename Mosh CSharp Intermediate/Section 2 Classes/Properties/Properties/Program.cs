using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1992, 5, 13));
            Console.WriteLine(person.Age);
        }
    }
}
