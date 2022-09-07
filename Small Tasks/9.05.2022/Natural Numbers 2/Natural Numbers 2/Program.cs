using System;

namespace Natural_Numbers_2
{
    internal class Program
    {
        public static void Main()
        {
            int i, n, sum = 0;
            double avg;

            Console.WriteLine("Read 10 numbers and calculate sum & average:");
            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("Input the 10 numbers");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }

            avg = sum / 10.0;
            Console.Write("The sum of the 10 numbers is: {0} The average is: {1}", sum, avg);
            Console.ReadKey();
        }
    }
}