using System;
using System.IO.IsolatedStorage;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's Morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's Evening.");
            }

            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            var price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);


            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("it is Summer");
                    break;
                default:
                    Console.WriteLine("It is either Spring or Winter");
                    break;
                    
            }



        }
    }
}
