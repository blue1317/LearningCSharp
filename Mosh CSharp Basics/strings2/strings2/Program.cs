using System;

namespace strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Chris Foley ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("ToLower: '{0}'", fullName.Trim().ToLower());

            // substring and IndexOf
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            // array with split
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LasttName: " + names[1]);

            Console.WriteLine(fullName.Replace("Chris", "Christopher"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            // convert
            var str = "29";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);


            float price = 29.99f;
            Console.WriteLine(price.ToString("C0"));


        }
    }
}
