using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _brithdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _brithdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _brithdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1992, 5, 13));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
