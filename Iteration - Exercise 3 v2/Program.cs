using System;

namespace Iteration___Exercise_3_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number & I will calculate the factorial for you!!!");
           
            int input = Convert.ToInt32(Console.ReadLine());
          //  int output = input;
           // int factorialOutput = 0;
            int factorialResult = 1;

                for (int userNumber = input; userNumber >= 1; userNumber --)
                {
                //factorialOutput = factorial * output; // unnecessary line

                factorialResult = factorialResult * userNumber;

                }

            Console.WriteLine($"The Factorial is {input}! = {factorialResult} ");
        }
    }
}
