using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLength = 15;
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = ((char)('a' + random.Next(0, 26)));
                
            }

            var password = new string(buffer);


            Console.WriteLine(password);

            //Console.WriteLine((int)'H');

        }
    }
}
