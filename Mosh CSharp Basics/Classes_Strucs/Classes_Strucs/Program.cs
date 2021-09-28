using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Strucs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some people for our program
            var john = new Person();
            var sally = new Person();
            var adam = new Person();
            var isa = new Person();

            // Lets get our people some more data
            john.firstName = "John";
            john.lastName = "Doe";
            john.age = 28;
            john.hobby = "Hunting";

            sally.firstName = "Sally";
            sally.lastName = "Smith";
            sally.age = 22;
            sally.hobby = "Photography";

            adam.firstName = "Adam";
            adam.lastName = "Brown";
            adam.age = 35;
            adam.hobby = "Fishing";

            isa.firstName = "Isa";
            isa.lastName = "Foley";
            isa.age = 18;
            isa.hobby = "Boxing";

            // Lets introduce everybody
            john.Introduction();
            sally.Introduction();
            adam.Introduction();
            isa.Introduction();

            Console.WriteLine("We are about to use a calculator now, but first leasts clear out our Console. Press enter when you are ready to move on.");
            Console.ReadLine();

            //Gather data for our Calculator
            
            var calcReuse = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Now lets test out a calculator where we take in 2 user input.");
                Console.WriteLine(" ");
                Console.WriteLine("Enter your first number");
                var firstNumber = Console.ReadLine();

                Console.WriteLine("Enter your second number");
                var secondNumber = Console.ReadLine();

                Console.WriteLine("Now enter in your operation suchs as + for add, - for subtract, * for multiply and / for division");
                var operand = Console.ReadLine();

                // Before we can use the calculator we need to create the object and convert our inputs. We also need to create logic for our operation
                var calculator = new Calculator();

                var a = Convert.ToInt32(firstNumber);
                var b = Convert.ToInt32(secondNumber);
                
                int calcResult = 0;
                // Send the data we gathered to the calculator class so we can see the answer
            
                if (operand == "+")
                {
                    calcResult = calculator.calcAdd(a, b);
                }
                else if (operand == "-")
                {
                    calcResult = calculator.calcSub(a, b);
                }
                else if (operand == "*")
                {
                    calcResult = calculator.calcMulti(a, b);
                }
                else if (operand == "/")
                {
                    calcResult = calculator.calcDiv(a, b);
                }

                // Lets display our results
                Console.WriteLine(a + " " + operand + " " + b + " = " + calcResult);

                // Lets check if there is anymore equations to solve.
                Console.WriteLine("Do you want to try something new (Y for Yes, N for No)?");
                calcReuse = Console.ReadLine();
            } while (calcReuse.ToUpper() == "Y");
            


        }
    }
}
