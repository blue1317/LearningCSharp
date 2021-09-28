using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Strucs
{
    public class Calculator
    {

        public int calcAdd(int a, int b)
        {
            return a + b;
        }

        public int calcSub(int a, int b)
        {
            return a - b;
        }

        public int calcMulti(int a, int b)
        {
            return a * b;
        }

        public int calcDiv(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" ");
                Console.WriteLine("NOTE: Technically you cant divide by 0, so you will just end up with what you started with!");
                return a;
            }
            
        }

    }
}
