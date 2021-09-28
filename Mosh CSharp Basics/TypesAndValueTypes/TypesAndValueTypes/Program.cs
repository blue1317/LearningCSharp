using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Referenece types have their values stored in the Stack, which means that their values point to a 
             * specific location in ram, and will use that regardless how many objects that share the name of the value
             * Value types store their values in the Heap, therefore it will create a new location in ram to store a new variables.
            */ 


            // Example one - value type
            var a = 10;
            var b = a;
            b++;
            // Expected values are: a = 10, b = 11 (a + 1 = 11)
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            
            // Example two - refernece type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            // Expected values are: array1[0] = 0, array2[0] = 0
            Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0]));

            // Example three - Value type
            var number = 1;
            Increment(number);
            // Expected values are: number = 1
            Console.WriteLine(number);

            // Example four - reference Type
            var person = new Person() { Age = 20 };
            MakeOld(person);
            // Expected values are: age = 30 (20 + 10 (from the method MakeOld) = 30)
            Console.WriteLine(person.Age);
        }
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }

    public class Person
    {
        public int Age;
    }
}
