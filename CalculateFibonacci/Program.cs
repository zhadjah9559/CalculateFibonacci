using System;

namespace CalculateFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3;

            Console.WriteLine("How many numbers of the fibonacci series would you like to see?");
            int count = Int32.Parse(Console.ReadLine());

            //First number in the series
            Console.Write(num1 + " " + num2);
            
            for(int i = 2; i < count; i++)
            {
                num3 = num1 + num2;
                Console.Write(" " + num3);
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
