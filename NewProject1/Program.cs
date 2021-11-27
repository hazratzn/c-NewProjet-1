using System;

namespace NewProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 25;

            num1 = num1 + num2;

            num2 = num1 - num2;

            num1 = num1 - num2;


            Console.WriteLine(num1 + " " + num2);
        }
    }
}
