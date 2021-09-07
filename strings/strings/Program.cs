using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Chris";

            //or

            var lastName = "Foley";

            // concat strings
            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"John", "Mary", "Jack" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            var text = string.Format("Hi John\nYou should talk to {0} and {1} about the following paths:\nc:\\Folder1", names[1], names[2]);

            // You could also do something like this

            var text2 = @"Hi John
You should talk to Mary and Jack about the following paths:
c:\Folder1";

            Console.WriteLine(text);
            Console.WriteLine(text2);
        }
    }
}
