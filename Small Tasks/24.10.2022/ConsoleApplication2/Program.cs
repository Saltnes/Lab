using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (CheckPrime(num))
                Console.WriteLine(num + " is a prime number");
            else
                Console.Write(num + " is not a prime number");
        }

        private static bool CheckPrime(int number)
        {
            for(int i=2; i < number; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}