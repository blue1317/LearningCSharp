using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Chris");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
