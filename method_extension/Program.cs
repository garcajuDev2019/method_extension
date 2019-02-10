using System;
using System.Text;

namespace method_extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.Write("Please, insert a number: ");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("Wrong or invalid numeric value!");
            }

            bool isPrime = num.IsPrime(); //Calling to extended method
            PrintResult(num, isPrime);
        }

        static void PrintResult(int num, bool isPrime)
        {
            StringBuilder result;

            if (isPrime)
            {
                result = new StringBuilder(" is a prime number");
                result.Insert(0, num);
            }
            else
            {
                result = new StringBuilder(" is not a prime number");
                result.Insert(0, num);
            }
            Console.WriteLine(value: result);
        }
    }
}
